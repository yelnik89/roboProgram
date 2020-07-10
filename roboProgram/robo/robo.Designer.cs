namespace robo
{
    partial class robo
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
            this.login = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ключь (UUID)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uuid
            // 
            this.uuid.Location = new System.Drawing.Point(119, 65);
            this.uuid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uuid.Name = "uuid";
            this.uuid.Size = new System.Drawing.Size(463, 22);
            this.uuid.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(16, 149);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(716, 378);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // sendReqest
            // 
            this.sendReqest.Location = new System.Drawing.Point(439, 101);
            this.sendReqest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendReqest.Name = "sendReqest";
            this.sendReqest.Size = new System.Drawing.Size(144, 28);
            this.sendReqest.TabIndex = 5;
            this.sendReqest.Text = "отправить запрос";
            this.sendReqest.UseVisualStyleBackColor = true;
            this.sendReqest.Click += new System.EventHandler(this.sendReqest_Click);
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(591, 101);
            this.myIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(143, 28);
            this.myIP.TabIndex = 6;
            this.myIP.Text = "запрос на myIP";
            this.myIP.UseVisualStyleBackColor = true;
            this.myIP.Click += new System.EventHandler(this.myIP_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(337, 103);
            this.port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(91, 22);
            this.port.TabIndex = 7;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(283, 107);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(45, 17);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Порт:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(12, 107);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(24, 17);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(47, 103);
            this.ip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(227, 22);
            this.ip.TabIndex = 10;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(80, 30);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(221, 22);
            this.login.TabIndex = 11;
            this.login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(12, 33);
            this.LoginText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(47, 17);
            this.LoginText.TabIndex = 12;
            this.LoginText.Text = "Логин";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(316, 33);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(57, 17);
            this.passwordText.TabIndex = 13;
            this.passwordText.Text = "Пароль";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(384, 30);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(348, 22);
            this.password.TabIndex = 14;
            // 
            // robo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 543);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.login);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.port);
            this.Controls.Add(this.myIP);
            this.Controls.Add(this.sendReqest);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.uuid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "robo";
            this.Text = "robo";
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
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox password;
    }
}

