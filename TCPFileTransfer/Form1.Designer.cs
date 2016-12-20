namespace TCPFileTransfer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxPort = new System.Windows.Forms.TextBox();
            this.statusbar = new System.Windows.Forms.TextBox();
            this.Select_File = new System.Windows.Forms.Button();
            this.SendFile = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.on_vutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Клиент ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Сервер";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 48);
            this.panel1.TabIndex = 2;
            // 
            // textboxIP
            // 
            this.textboxIP.Location = new System.Drawing.Point(185, 17);
            this.textboxIP.Name = "textboxIP";
            this.textboxIP.Size = new System.Drawing.Size(229, 20);
            this.textboxIP.TabIndex = 3;
            this.textboxIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Adress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // textboxPort
            // 
            this.textboxPort.Location = new System.Drawing.Point(185, 43);
            this.textboxPort.Name = "textboxPort";
            this.textboxPort.Size = new System.Drawing.Size(229, 20);
            this.textboxPort.TabIndex = 5;
            this.textboxPort.Text = "11000";
            // 
            // statusbar
            // 
            this.statusbar.Location = new System.Drawing.Point(12, 114);
            this.statusbar.Multiline = true;
            this.statusbar.Name = "statusbar";
            this.statusbar.ReadOnly = true;
            this.statusbar.Size = new System.Drawing.Size(402, 163);
            this.statusbar.TabIndex = 7;
            // 
            // Select_File
            // 
            this.Select_File.Enabled = false;
            this.Select_File.Location = new System.Drawing.Point(85, 69);
            this.Select_File.Name = "Select_File";
            this.Select_File.Size = new System.Drawing.Size(82, 39);
            this.Select_File.TabIndex = 8;
            this.Select_File.Text = "Выбор файла";
            this.Select_File.UseVisualStyleBackColor = true;
            this.Select_File.Click += new System.EventHandler(this.Select_File_Click);
            // 
            // SendFile
            // 
            this.SendFile.Enabled = false;
            this.SendFile.Location = new System.Drawing.Point(258, 69);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(75, 39);
            this.SendFile.TabIndex = 9;
            this.SendFile.Text = "Начать передачу";
            this.SendFile.UseVisualStyleBackColor = true;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Location = new System.Drawing.Point(173, 69);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(79, 39);
            this.button_Connect.TabIndex = 10;
            this.button_Connect.Text = "Установить соединение";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(339, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ещё разок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // on_vutton
            // 
            this.on_vutton.Location = new System.Drawing.Point(12, 69);
            this.on_vutton.Name = "on_vutton";
            this.on_vutton.Size = new System.Drawing.Size(67, 39);
            this.on_vutton.TabIndex = 12;
            this.on_vutton.Text = "Включить";
            this.on_vutton.UseVisualStyleBackColor = true;
            this.on_vutton.Click += new System.EventHandler(this.on_vutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 289);
            this.Controls.Add(this.on_vutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.SendFile);
            this.Controls.Add(this.Select_File);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxIP);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxPort;
        private System.Windows.Forms.TextBox statusbar;
        private System.Windows.Forms.Button Select_File;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button on_vutton;
    }
}

