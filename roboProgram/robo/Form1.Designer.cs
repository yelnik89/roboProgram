﻿namespace robo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uuid = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.sendReqest = new System.Windows.Forms.Button();
            this.myIP = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ключь (UUID)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uuid
            // 
            this.uuid.Location = new System.Drawing.Point(89, 18);
            this.uuid.Name = "uuid";
            this.uuid.Size = new System.Drawing.Size(233, 20);
            this.uuid.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 84);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(310, 272);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // sendReqest
            // 
            this.sendReqest.Location = new System.Drawing.Point(329, 45);
            this.sendReqest.Name = "sendReqest";
            this.sendReqest.Size = new System.Drawing.Size(108, 23);
            this.sendReqest.TabIndex = 5;
            this.sendReqest.Text = "отправить запрос";
            this.sendReqest.UseVisualStyleBackColor = true;
            this.sendReqest.Click += new System.EventHandler(this.sendReqest_Click);
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(329, 332);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(107, 23);
            this.myIP.TabIndex = 6;
            this.myIP.Text = "запрос на myIP";
            this.myIP.UseVisualStyleBackColor = true;
            this.myIP.Click += new System.EventHandler(this.myIP_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(253, 47);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(69, 20);
            this.port.TabIndex = 7;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(212, 50);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(35, 13);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Порт:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(9, 50);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(20, 13);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(35, 47);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(171, 20);
            this.ip.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 368);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.port);
            this.Controls.Add(this.myIP);
            this.Controls.Add(this.sendReqest);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.uuid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uuid;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button sendReqest;
        private System.Windows.Forms.Button myIP;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ip;
    }
}

