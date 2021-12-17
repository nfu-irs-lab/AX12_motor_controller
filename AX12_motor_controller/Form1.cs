using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace AX12_motor_controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            serialPort.BaudRate = 1000000; // 預設鮑率為：1000000。
            UpdateSerialPortNames();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                // Serial Port 已開啟，嘗試關閉。
                try
                {
                    serialPort.Close();
                    button_connect.Text = "Connect";
                    comboBox_portName.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"斷線時出錯。\r\n{ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                // 更新 Port name。
                serialPort.PortName = comboBox_portName.SelectedItem.ToString();

                // Serial Port 未開啟，嘗試開啟。
                try
                {
                    serialPort.Open();
                    button_connect.Text = "Disconnect";
                    comboBox_portName.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"連線時出錯。\r\n{ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDown_motor_id.Value;
            int position = (int)numericUpDown_motor_pos.Value;
            int speed = (int)numericUpDown_motor_speed.Value;

            ControlAX12(id, position, speed);
        }

        private void comboBox_portName_Click(object sender, EventArgs e)
        {
            UpdateSerialPortNames();
        }

        /// <summary>
        /// 控制 AX-12 馬達。
        /// </summary>
        /// <param name="id">馬達ID，允許範圍為 0 ~ 254，254為全體廣播ID。</param>
        /// <param name="position">目標位置，允許範圍為 0 ~ 1023。</param>
        /// <param name="speed">速度，允許範圍為 0 ~ 1023。</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void ControlAX12(int id, int position, int speed)
        {
            // 避免數值超出允許範圍。
            if (id < 0 || id > 254)
            {
                throw new ArgumentOutOfRangeException("馬達ID超出允許範圍 (0 ~ 254，254為全體廣播ID)。");
            }

            if (position > 1023)
            {
                position = 1023;
            }
            else if (position < 0)
            {
                position = 0;
            }

            if (speed > 1023)
            {
                speed = 1023;
            }
            else if (speed < 0)
            {
                speed = 0;
            }

            // 建立資料封包。
            // 官方說明：https://emanual.robotis.com/docs/en/dxl/protocol1/#instruction-packet
            byte[] dataPackage = new byte[11];
            dataPackage[0] = 0xFF;     // 標頭1 (Header1)，固定為0xFF。
            dataPackage[1] = 0xFF;     // 標頭2 (Header2)，固定為0xFF。
            dataPackage[2] = (byte)id; // 封包傳送的ID (Packet ID)。
            dataPackage[3] = (byte)7;  // 長度 (Length)，其數值為參數位元組數量+3。
            dataPackage[4] = 0x03;     // 指令 (Instruction)，0x03為"Write"指令。
            dataPackage[5] = (byte)30; // 起始地址 (Starting address)。地址"30"對應的是"Goal Position"。
            dataPackage[6] = (byte)(position & 0xFF); // "Goal Position"參數位元組1 (低8位元)。
            dataPackage[7] = (byte)(position >> 8);   // "Goal Position"參數位元組2 (高8位元)。
            dataPackage[8] = (byte)(speed & 0xFF);    // "Moving Speed"參數位元組1 (低8位元)。
            dataPackage[9] = (byte)(speed >> 8);      // "Moving Speed"參數位元組2 (高8位元)。

            // 計算校驗和 (Checksum)。
            byte a = 0;
            for (int i = 2; i < 10; i++)
            {
                a += dataPackage[i];
            }
            dataPackage[10] = (byte)(0xFF - a);

            try
            {
                serialPort.Write(dataPackage, 0, dataPackage.Length); // 傳送。
                Thread.Sleep(1); // Delay 1 ms.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"傳送封包時出錯。\r\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 更新Serial Port Name下拉式選單。
        /// </summary>
        private void UpdateSerialPortNames()
        {
            comboBox_portName.Items.Clear();

            string[] allPortNames = SerialPort.GetPortNames(); // 取得所有已連接的 Serial Port。
            if (allPortNames.Length > 0)
            {
                comboBox_portName.Items.AddRange(allPortNames);
            }
            else
            {
                comboBox_portName.Items.Add("找不到任何裝置，點擊更新");
            }

            comboBox_portName.SelectedIndex = 0; // 選擇第1個項目。
        }
    }
}