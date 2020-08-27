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
            this.KeyText = new System.Windows.Forms.Label();
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
            this.authorizationType = new System.Windows.Forms.ComboBox();
            this.autorizationLabel = new System.Windows.Forms.Label();
            this.thingList = new System.Windows.Forms.ComboBox();
            this.ThingNameLabel = new System.Windows.Forms.Label();
            this.ThingName = new System.Windows.Forms.TextBox();
            this.ParamsNames = new System.Windows.Forms.RichTextBox();
            this.ParamsValues = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // KeyText
            // 
            this.KeyText.AutoSize = true;
            this.KeyText.Location = new System.Drawing.Point(9, 56);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(68, 13);
            this.KeyText.TabIndex = 2;
            this.KeyText.Text = "ключ (UUID)";
            this.KeyText.Click += new System.EventHandler(this.label1_Click);
            // 
            // uuid
            // 
            this.uuid.Location = new System.Drawing.Point(86, 53);
            this.uuid.Name = "uuid";
            this.uuid.Size = new System.Drawing.Size(236, 20);
            this.uuid.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(10, 121);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(538, 621);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // sendReqest
            // 
            this.sendReqest.Location = new System.Drawing.Point(441, 81);
            this.sendReqest.Name = "sendReqest";
            this.sendReqest.Size = new System.Drawing.Size(108, 23);
            this.sendReqest.TabIndex = 5;
            this.sendReqest.Text = "отправить запрос";
            this.sendReqest.UseVisualStyleBackColor = true;
            this.sendReqest.Click += new System.EventHandler(this.sendReqest_Click);
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(441, 51);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(108, 23);
            this.myIP.TabIndex = 6;
            this.myIP.Text = "запрос на myIP";
            this.myIP.UseVisualStyleBackColor = true;
            this.myIP.Click += new System.EventHandler(this.myIP_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(193, 83);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(41, 20);
            this.port.TabIndex = 7;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(152, 86);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(35, 13);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Порт:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(11, 86);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(20, 13);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(37, 83);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(104, 20);
            this.ip.TabIndex = 10;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(60, 24);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(146, 20);
            this.login.TabIndex = 11;
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(9, 27);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(38, 13);
            this.LoginText.TabIndex = 12;
            this.LoginText.Text = "Логин";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(237, 27);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(45, 13);
            this.passwordText.TabIndex = 13;
            this.passwordText.Text = "Пароль";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(288, 24);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(262, 20);
            this.password.TabIndex = 14;
            // 
            // authorizationType
            // 
            this.authorizationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorizationType.FormattingEnabled = true;
            this.authorizationType.Items.AddRange(new object[] {
            "по ключу",
            "по логину"});
            this.authorizationType.Location = new System.Drawing.Point(348, 82);
            this.authorizationType.Margin = new System.Windows.Forms.Padding(2);
            this.authorizationType.Name = "authorizationType";
            this.authorizationType.Size = new System.Drawing.Size(83, 21);
            this.authorizationType.TabIndex = 15;
            // 
            // autorizationLabel
            // 
            this.autorizationLabel.AutoSize = true;
            this.autorizationLabel.Location = new System.Drawing.Point(250, 86);
            this.autorizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autorizationLabel.Name = "autorizationLabel";
            this.autorizationLabel.Size = new System.Drawing.Size(94, 13);
            this.autorizationLabel.TabIndex = 16;
            this.autorizationLabel.Text = "Тип авторизации";
            // 
            // thingList
            // 
            this.thingList.FormattingEnabled = true;
            this.thingList.Location = new System.Drawing.Point(585, 24);
            this.thingList.Name = "thingList";
            this.thingList.Size = new System.Drawing.Size(260, 21);
            this.thingList.TabIndex = 17;
            this.thingList.SelectedIndexChanged += new System.EventHandler(this.thingList_SelectedIndexChanged);
            // 
            // ThingNameLabel
            // 
            this.ThingNameLabel.AutoSize = true;
            this.ThingNameLabel.Location = new System.Drawing.Point(582, 56);
            this.ThingNameLabel.Name = "ThingNameLabel";
            this.ThingNameLabel.Size = new System.Drawing.Size(65, 13);
            this.ThingNameLabel.TabIndex = 90;
            this.ThingNameLabel.Text = "Thing Name";
            // 
            // ThingName
            // 
            this.ThingName.Location = new System.Drawing.Point(653, 53);
            this.ThingName.Name = "ThingName";
            this.ThingName.Size = new System.Drawing.Size(192, 20);
            this.ThingName.TabIndex = 91;
            // 
            // ParamsNames
            // 
            this.ParamsNames.Location = new System.Drawing.Point(585, 121);
            this.ParamsNames.Name = "ParamsNames";
            this.ParamsNames.ReadOnly = true;
            this.ParamsNames.Size = new System.Drawing.Size(111, 621);
            this.ParamsNames.TabIndex = 92;
            this.ParamsNames.Text = "";
            // 
            // ParamsValues
            // 
            this.ParamsValues.Location = new System.Drawing.Point(702, 121);
            this.ParamsValues.Name = "ParamsValues";
            this.ParamsValues.ReadOnly = true;
            this.ParamsValues.Size = new System.Drawing.Size(143, 621);
            this.ParamsValues.TabIndex = 93;
            this.ParamsValues.Text = "";
            // 
            // robo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 754);
            this.Controls.Add(this.ParamsValues);
            this.Controls.Add(this.ParamsNames);
            this.Controls.Add(this.ThingName);
            this.Controls.Add(this.ThingNameLabel);
            this.Controls.Add(this.autorizationLabel);
            this.Controls.Add(this.authorizationType);
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
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.thingList);
            this.Name = "robo";
            this.Text = "robo";
            this.Load += new System.EventHandler(this.robo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KeyText;
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
        private System.Windows.Forms.ComboBox authorizationType;
        private System.Windows.Forms.Label autorizationLabel;
        private System.Windows.Forms.ComboBox thingList;
        private System.Windows.Forms.Label ThingNameLabel;
        private System.Windows.Forms.TextBox ThingName;
        private System.Windows.Forms.RichTextBox ParamsNames;
        private System.Windows.Forms.RichTextBox ParamsValues;
    }
}

