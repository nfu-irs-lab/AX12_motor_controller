/*
 * Name: AX-12 motor controller
 * Date: 2021-March-19
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AX12_motor_controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                // 嘗試尋找所有連接的 Serial Port。
                // 並將第一個裝置的 Port Name 寫入 textBox_comport。
                textBox_comport.Text = SerialPort.GetPortNames()[0];
            }
            catch
            {
                textBox_comport.Text = "COM1";
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 已開啟，嘗試關閉 Serial Port。
                try
                {
                    serialPort1.Close();
                    button_connect.Text = "Connect";
                    textBox_comport.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error!\r\n{ex.Message}");
                }
            }
            else
            {
                // 更新 Port name。
                serialPort1.PortName = textBox_comport.Text;

                // 未開啟，嘗試開啟 Serial Port。
                try
                {
                    serialPort1.Open();
                    button_connect.Text = "Disconnect";
                    textBox_comport.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error!\r\n{ex.Message}");
                }
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            AX12((int)numericUpDown_motor_id.Value,
                 (int)numericUpDown_motor_pos.Value,
                 (int)numericUpDown_motor_speed.Value);
        }

        /// <summary>
        /// Control the AX-12 motor.
        /// </summary>
        /// <param name="id">馬達 ID</param>
        /// <param name="position">目標位置</param>
        /// <param name="speed">速度</param>
        private void AX12(int id, int position, int speed)
        {
            // 避免數值超出允許範圍。
            if (position > 1023)
            {
                position = 1023;
            }
            else if (position < 0)
            {
                position = 0;
            }

            // 建立傳輸資料。
            byte[] data = new byte[11];
            data[0] = 0xff;
            data[1] = 0xff;
            data[2] = (byte)id;
            data[3] = 0x07;
            data[4] = 0x03;
            data[5] = 0x1e;
            data[6] = (byte)(position % 256);
            data[7] = (byte)(position / 256);
            data[8] = (byte)(0xff & speed);
            data[9] = (byte)(speed / 256);
            byte a = 0;
            for (int i = 2; i < 10; i++)
            {
                a += data[i];
            }
            data[10] = (byte)(0xff - a);

            // Send.
            try
            {
                serialPort1.Write(data, 0, 11);
                Thread.Sleep(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error!\r\n{ex.Message}");
            }
        }
    }
}