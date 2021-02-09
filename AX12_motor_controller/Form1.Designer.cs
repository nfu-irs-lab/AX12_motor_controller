namespace AX12_motor_controller
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.numericUpDown_motor_id = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_motor_pos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_motor_speed = new System.Windows.Forms.NumericUpDown();
            this.label_motor_id = new System.Windows.Forms.Label();
            this.label_motor_pos = new System.Windows.Forms.Label();
            this.label_motor_speed = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_motor = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_comport = new System.Windows.Forms.TextBox();
            this.label_comport = new System.Windows.Forms.Label();
            this.groupBox_sp = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_speed)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_motor.SuspendLayout();
            this.groupBox_sp.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1000000;
            // 
            // numericUpDown_motor_id
            // 
            this.numericUpDown_motor_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_motor_id.Location = new System.Drawing.Point(121, 8);
            this.numericUpDown_motor_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_motor_id.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_motor_id.Name = "numericUpDown_motor_id";
            this.numericUpDown_motor_id.Size = new System.Drawing.Size(107, 25);
            this.numericUpDown_motor_id.TabIndex = 0;
            // 
            // numericUpDown_motor_pos
            // 
            this.numericUpDown_motor_pos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_motor_pos.Location = new System.Drawing.Point(121, 49);
            this.numericUpDown_motor_pos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_motor_pos.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDown_motor_pos.Name = "numericUpDown_motor_pos";
            this.numericUpDown_motor_pos.Size = new System.Drawing.Size(107, 25);
            this.numericUpDown_motor_pos.TabIndex = 1;
            this.numericUpDown_motor_pos.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // numericUpDown_motor_speed
            // 
            this.numericUpDown_motor_speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_motor_speed.Location = new System.Drawing.Point(121, 91);
            this.numericUpDown_motor_speed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_motor_speed.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDown_motor_speed.Name = "numericUpDown_motor_speed";
            this.numericUpDown_motor_speed.Size = new System.Drawing.Size(107, 25);
            this.numericUpDown_motor_speed.TabIndex = 2;
            this.numericUpDown_motor_speed.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label_motor_id
            // 
            this.label_motor_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_motor_id.AutoSize = true;
            this.label_motor_id.Location = new System.Drawing.Point(86, 0);
            this.label_motor_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_motor_id.Name = "label_motor_id";
            this.label_motor_id.Size = new System.Drawing.Size(26, 41);
            this.label_motor_id.TabIndex = 3;
            this.label_motor_id.Text = "ID:";
            this.label_motor_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_motor_pos
            // 
            this.label_motor_pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_motor_pos.AutoSize = true;
            this.label_motor_pos.Location = new System.Drawing.Point(55, 41);
            this.label_motor_pos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_motor_pos.Name = "label_motor_pos";
            this.label_motor_pos.Size = new System.Drawing.Size(57, 41);
            this.label_motor_pos.TabIndex = 4;
            this.label_motor_pos.Text = "Position:";
            this.label_motor_pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_motor_speed
            // 
            this.label_motor_speed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_motor_speed.AutoSize = true;
            this.label_motor_speed.Location = new System.Drawing.Point(67, 82);
            this.label_motor_speed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_motor_speed.Name = "label_motor_speed";
            this.label_motor_speed.Size = new System.Drawing.Size(45, 43);
            this.label_motor_speed.TabIndex = 5;
            this.label_motor_speed.Text = "Speed:";
            this.label_motor_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_motor_id, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_motor_speed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_motor_pos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_motor_pos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_motor_speed, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_motor_id, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 125);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox_motor
            // 
            this.groupBox_motor.Controls.Add(this.button_send);
            this.groupBox_motor.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_motor.Location = new System.Drawing.Point(16, 126);
            this.groupBox_motor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_motor.Name = "groupBox_motor";
            this.groupBox_motor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_motor.Size = new System.Drawing.Size(241, 200);
            this.groupBox_motor.TabIndex = 7;
            this.groupBox_motor.TabStop = false;
            this.groupBox_motor.Text = "AX-12 Control";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(135, 155);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(100, 29);
            this.button_send.TabIndex = 9;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(132, 61);
            this.button_connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(100, 29);
            this.button_connect.TabIndex = 8;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox_comport
            // 
            this.textBox_comport.Location = new System.Drawing.Point(125, 26);
            this.textBox_comport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_comport.Name = "textBox_comport";
            this.textBox_comport.Size = new System.Drawing.Size(105, 25);
            this.textBox_comport.TabIndex = 11;
            // 
            // label_comport
            // 
            this.label_comport.AutoSize = true;
            this.label_comport.Location = new System.Drawing.Point(41, 30);
            this.label_comport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_comport.Name = "label_comport";
            this.label_comport.Size = new System.Drawing.Size(71, 15);
            this.label_comport.TabIndex = 12;
            this.label_comport.Text = "COM Port:";
            // 
            // groupBox_sp
            // 
            this.groupBox_sp.Controls.Add(this.textBox_comport);
            this.groupBox_sp.Controls.Add(this.button_connect);
            this.groupBox_sp.Controls.Add(this.label_comport);
            this.groupBox_sp.Location = new System.Drawing.Point(16, 13);
            this.groupBox_sp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_sp.Name = "groupBox_sp";
            this.groupBox_sp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_sp.Size = new System.Drawing.Size(241, 104);
            this.groupBox_sp.TabIndex = 13;
            this.groupBox_sp.TabStop = false;
            this.groupBox_sp.Text = "Serial Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 344);
            this.Controls.Add(this.groupBox_motor);
            this.Controls.Add(this.groupBox_sp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "AX-12 Motor Controller";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_speed)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_motor.ResumeLayout(false);
            this.groupBox_sp.ResumeLayout(false);
            this.groupBox_sp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NumericUpDown numericUpDown_motor_id;
        private System.Windows.Forms.NumericUpDown numericUpDown_motor_pos;
        private System.Windows.Forms.NumericUpDown numericUpDown_motor_speed;
        private System.Windows.Forms.Label label_motor_id;
        private System.Windows.Forms.Label label_motor_pos;
        private System.Windows.Forms.Label label_motor_speed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_motor;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_comport;
        private System.Windows.Forms.Label label_comport;
        private System.Windows.Forms.GroupBox groupBox_sp;
    }
}

