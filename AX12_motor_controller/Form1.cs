
/*
 * Name: AX-12 motor controller
 * Date: 2020-December-04
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
                try
                {
                    serialPort1.Close();
                    button_connect.Text = "Connect";
                    textBox_comport.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n" + ex.Message);
                }
            }
            else
            {
                serialPort1.PortName = textBox_comport.Text;
                try
                {
                    serialPort1.Open();
                    button_connect.Text = "Disconnect";
                    textBox_comport.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n" + ex.Message);
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
        /// <param name="id"></param>
        /// <param name="pos"></param>
        /// <param name="speed"></param>
        private void AX12(int id, int pos, int speed)
        {
            if (pos > 1023)
            {
                pos = 1023;
            }
            else if (pos < 0)
            {
                pos = 0;
            }

            byte[] wd = new byte[11];
            wd[0] = 0xff;
            wd[1] = 0xff;
            wd[2] = (byte)id;
            wd[3] = 0x07;
            wd[4] = 0x03;
            wd[5] = 0x1e;
            wd[6] = (byte)(pos % 256);
            wd[7] = (byte)(pos / 256);
            wd[8] = (byte)(0xff & speed);
            wd[9] = (byte)(speed / 256);

            byte a = 0;
            for (int i = 2; i < 10; i++)
            {
                a += wd[i];
            }
            wd[10] = (byte)(0xff - a);

            // Send
            try
            {
                serialPort1.Write(wd, 0, 11);
                Thread.Sleep(1);
            }
            catch
            {
            }
        }
    }
}
