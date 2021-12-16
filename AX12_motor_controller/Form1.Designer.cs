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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
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
            this.label_comport = new System.Windows.Forms.Label();
            this.groupBox_sp = new System.Windows.Forms.GroupBox();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_motor_speed)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_motor.SuspendLayout();
            this.groupBox_sp.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown_motor_id
            // 
            this.numericUpDown_motor_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_motor_id.Location = new System.Drawing.Point(166, 5);
            this.numericUpDown_motor_id.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericUpDown_motor_id.Name = "numericUpDown_motor_id";
            this.numericUpDown_motor_id.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown_motor_id.TabIndex = 0;
            // 
            // numericUpDown_motor_pos
            // 
            this.numericUpDown_motor_pos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_motor_pos.Location = new System.Drawing.Point(166, 38);
            this.numericUpDown_motor_pos.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDown_motor_pos.Name = "numericUpDown_motor_pos";
            this.numericUpDown_motor_pos.Size = new System.Drawing.Size(80, 22);
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
            this.numericUpDown_motor_speed.Location = new System.Drawing.Point(166, 72);
            this.numericUpDown_motor_speed.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.numericUpDown_motor_speed.Name = "numericUpDown_motor_speed";
            this.numericUpDown_motor_speed.Size = new System.Drawing.Size(80, 22);
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
            this.label_motor_id.Location = new System.Drawing.Point(114, 0);
            this.label_motor_id.Name = "label_motor_id";
            this.label_motor_id.Size = new System.Drawing.Size(20, 33);
            this.label_motor_id.TabIndex = 3;
            this.label_motor_id.Text = "ID:";
            this.label_motor_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_motor_pos
            // 
            this.label_motor_pos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_motor_pos.AutoSize = true;
            this.label_motor_pos.Location = new System.Drawing.Point(89, 33);
            this.label_motor_pos.Name = "label_motor_pos";
            this.label_motor_pos.Size = new System.Drawing.Size(45, 33);
            this.label_motor_pos.TabIndex = 4;
            this.label_motor_pos.Text = "Position:";
            this.label_motor_pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_motor_speed
            // 
            this.label_motor_speed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_motor_speed.AutoSize = true;
            this.label_motor_speed.Location = new System.Drawing.Point(98, 66);
            this.label_motor_speed.Name = "label_motor_speed";
            this.label_motor_speed.Size = new System.Drawing.Size(36, 34);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox_motor
            // 
            this.groupBox_motor.Controls.Add(this.button_send);
            this.groupBox_motor.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_motor.Location = new System.Drawing.Point(12, 101);
            this.groupBox_motor.Name = "groupBox_motor";
            this.groupBox_motor.Size = new System.Drawing.Size(281, 160);
            this.groupBox_motor.TabIndex = 7;
            this.groupBox_motor.TabStop = false;
            this.groupBox_motor.Text = "AX-12 Control";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(169, 124);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 9;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(185, 47);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 8;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_comport
            // 
            this.label_comport.AutoSize = true;
            this.label_comport.Location = new System.Drawing.Point(6, 24);
            this.label_comport.Name = "label_comport";
            this.label_comport.Size = new System.Drawing.Size(56, 12);
            this.label_comport.TabIndex = 12;
            this.label_comport.Text = "COM Port:";
            // 
            // groupBox_sp
            // 
            this.groupBox_sp.Controls.Add(this.comboBox_portName);
            this.groupBox_sp.Controls.Add(this.button_connect);
            this.groupBox_sp.Controls.Add(this.label_comport);
            this.groupBox_sp.Location = new System.Drawing.Point(12, 10);
            this.groupBox_sp.Name = "groupBox_sp";
            this.groupBox_sp.Size = new System.Drawing.Size(282, 83);
            this.groupBox_sp.TabIndex = 13;
            this.groupBox_sp.TabStop = false;
            this.groupBox_sp.Text = "Serial Port";
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(68, 21);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(192, 20);
            this.comboBox_portName.TabIndex = 13;
            this.comboBox_portName.Tag = "";
            this.comboBox_portName.Click += new System.EventHandler(this.comboBox_portName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 274);
            this.Controls.Add(this.groupBox_motor);
            this.Controls.Add(this.groupBox_sp);
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

        private System.IO.Ports.SerialPort serialPort;
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
        private System.Windows.Forms.Label label_comport;
        private System.Windows.Forms.GroupBox groupBox_sp;
        private System.Windows.Forms.ComboBox comboBox_portName;
    }
}

