﻿namespace robo
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
            this.CicleRequestStart = new System.Windows.Forms.Button();
            this.Temp = new System.Windows.Forms.TextBox();
            this.TextToTime = new System.Windows.Forms.Label();
            this.Team1 = new System.Windows.Forms.Button();
            this.TeamStart = new System.Windows.Forms.Button();
            this.AllThingsLabel = new System.Windows.Forms.Label();
            this.TeamThingsList = new System.Windows.Forms.ComboBox();
            this.TeamThingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KeyText
            // 
            this.KeyText.AutoSize = true;
            this.KeyText.Location = new System.Drawing.Point(12, 69);
            this.KeyText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(88, 17);
            this.KeyText.TabIndex = 2;
            this.KeyText.Text = "ключ (UUID)";
            // 
            // uuid
            // 
            this.uuid.Location = new System.Drawing.Point(115, 66);
            this.uuid.Margin = new System.Windows.Forms.Padding(4);
            this.uuid.Name = "uuid";
            this.uuid.Size = new System.Drawing.Size(313, 22);
            this.uuid.TabIndex = 3;
            this.uuid.Text = "f8163f2b-e748-402c-8396-cb9b8eef6a80";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(13, 149);
            this.logBox.Margin = new System.Windows.Forms.Padding(4);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(719, 506);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // sendReqest
            // 
            this.sendReqest.Location = new System.Drawing.Point(452, 62);
            this.sendReqest.Margin = new System.Windows.Forms.Padding(4);
            this.sendReqest.Name = "sendReqest";
            this.sendReqest.Size = new System.Drawing.Size(144, 28);
            this.sendReqest.TabIndex = 5;
            this.sendReqest.Text = "отправить запрос";
            this.sendReqest.UseVisualStyleBackColor = true;
            this.sendReqest.Click += new System.EventHandler(this.sendReqest_Click);
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(611, 62);
            this.myIP.Margin = new System.Windows.Forms.Padding(4);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(123, 28);
            this.myIP.TabIndex = 6;
            this.myIP.Text = "запрос на myIP";
            this.myIP.UseVisualStyleBackColor = true;
            this.myIP.Click += new System.EventHandler(this.myIP_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(258, 102);
            this.port.Margin = new System.Windows.Forms.Padding(4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(54, 22);
            this.port.TabIndex = 7;
            this.port.Text = "9080";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(203, 106);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(45, 17);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Порт:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(14, 106);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(24, 17);
            this.ipLabel.TabIndex = 9;
            this.ipLabel.Text = "IP:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(50, 102);
            this.ip.Margin = new System.Windows.Forms.Padding(4);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(137, 22);
            this.ip.TabIndex = 10;
            this.ip.Text = "94.159.91.166";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(80, 30);
            this.login.Margin = new System.Windows.Forms.Padding(4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(193, 22);
            this.login.TabIndex = 11;
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(12, 34);
            this.LoginText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(47, 17);
            this.LoginText.TabIndex = 12;
            this.LoginText.Text = "Логин";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(316, 34);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(57, 17);
            this.passwordText.TabIndex = 13;
            this.passwordText.Text = "Пароль";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(384, 30);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(348, 22);
            this.password.TabIndex = 14;
            // 
            // authorizationType
            // 
            this.authorizationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorizationType.FormattingEnabled = true;
            this.authorizationType.Items.AddRange(new object[] {
            "по ключу",
            "по логину"});
            this.authorizationType.Location = new System.Drawing.Point(464, 101);
            this.authorizationType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorizationType.Name = "authorizationType";
            this.authorizationType.Size = new System.Drawing.Size(109, 24);
            this.authorizationType.TabIndex = 15;
            // 
            // autorizationLabel
            // 
            this.autorizationLabel.AutoSize = true;
            this.autorizationLabel.Location = new System.Drawing.Point(333, 106);
            this.autorizationLabel.Name = "autorizationLabel";
            this.autorizationLabel.Size = new System.Drawing.Size(122, 17);
            this.autorizationLabel.TabIndex = 16;
            this.autorizationLabel.Text = "Тип авторизации";
            // 
            // thingList
            // 
            this.thingList.FormattingEnabled = true;
            this.thingList.Location = new System.Drawing.Point(1112, 30);
            this.thingList.Margin = new System.Windows.Forms.Padding(4);
            this.thingList.Name = "thingList";
            this.thingList.Size = new System.Drawing.Size(255, 24);
            this.thingList.TabIndex = 17;
            this.thingList.SelectedIndexChanged += new System.EventHandler(this.thingList_SelectedIndexChanged);
            // 
            // ThingNameLabel
            // 
            this.ThingNameLabel.AutoSize = true;
            this.ThingNameLabel.Location = new System.Drawing.Point(1017, 106);
            this.ThingNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThingNameLabel.Name = "ThingNameLabel";
            this.ThingNameLabel.Size = new System.Drawing.Size(85, 17);
            this.ThingNameLabel.TabIndex = 90;
            this.ThingNameLabel.Text = "Thing Name";
            // 
            // ThingName
            // 
            this.ThingName.Location = new System.Drawing.Point(1112, 102);
            this.ThingName.Margin = new System.Windows.Forms.Padding(4);
            this.ThingName.Name = "ThingName";
            this.ThingName.Size = new System.Drawing.Size(255, 22);
            this.ThingName.TabIndex = 91;
            // 
            // ParamsNames
            // 
            this.ParamsNames.Location = new System.Drawing.Point(1021, 149);
            this.ParamsNames.Margin = new System.Windows.Forms.Padding(4);
            this.ParamsNames.Name = "ParamsNames";
            this.ParamsNames.ReadOnly = true;
            this.ParamsNames.Size = new System.Drawing.Size(146, 506);
            this.ParamsNames.TabIndex = 92;
            this.ParamsNames.Text = "";
            // 
            // ParamsValues
            // 
            this.ParamsValues.Location = new System.Drawing.Point(1177, 149);
            this.ParamsValues.Margin = new System.Windows.Forms.Padding(4);
            this.ParamsValues.Name = "ParamsValues";
            this.ParamsValues.ReadOnly = true;
            this.ParamsValues.Size = new System.Drawing.Size(189, 506);
            this.ParamsValues.TabIndex = 93;
            this.ParamsValues.Text = "";
            // 
            // CicleRequestStart
            // 
            this.CicleRequestStart.Enabled = false;
            this.CicleRequestStart.Location = new System.Drawing.Point(764, 69);
            this.CicleRequestStart.Margin = new System.Windows.Forms.Padding(4);
            this.CicleRequestStart.Name = "CicleRequestStart";
            this.CicleRequestStart.Size = new System.Drawing.Size(211, 58);
            this.CicleRequestStart.TabIndex = 94;
            this.CicleRequestStart.Text = "START";
            this.CicleRequestStart.UseVisualStyleBackColor = true;
            this.CicleRequestStart.Click += new System.EventHandler(this.CircleRequestStart_Click);
            // 
            // Temp
            // 
            this.Temp.Location = new System.Drawing.Point(916, 30);
            this.Temp.Margin = new System.Windows.Forms.Padding(4);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(57, 22);
            this.Temp.TabIndex = 95;
            this.Temp.Text = "1000";
            this.Temp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Temp_KeyPress);
            // 
            // TextToTime
            // 
            this.TextToTime.AutoSize = true;
            this.TextToTime.Location = new System.Drawing.Point(760, 34);
            this.TextToTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextToTime.Name = "TextToTime";
            this.TextToTime.Size = new System.Drawing.Size(143, 17);
            this.TextToTime.TabIndex = 96;
            this.TextToTime.Text = "частота опроса в мс";
            // 
            // Team1
            // 
            this.Team1.Location = new System.Drawing.Point(1396, 26);
            this.Team1.Margin = new System.Windows.Forms.Padding(4);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(100, 28);
            this.Team1.TabIndex = 97;
            this.Team1.Text = "Team1";
            this.Team1.UseVisualStyleBackColor = true;
            this.Team1.Click += new System.EventHandler(this.Team1_Click);
            // 
            // TeamStart
            // 
            this.TeamStart.Location = new System.Drawing.Point(764, 149);
            this.TeamStart.Margin = new System.Windows.Forms.Padding(4);
            this.TeamStart.Name = "TeamStart";
            this.TeamStart.Size = new System.Drawing.Size(211, 62);
            this.TeamStart.TabIndex = 98;
            this.TeamStart.UseVisualStyleBackColor = true;
            this.TeamStart.Click += new System.EventHandler(this.TeamStart_Click);
            // 
            // AllThingsLabel
            // 
            this.AllThingsLabel.AutoSize = true;
            this.AllThingsLabel.Location = new System.Drawing.Point(1017, 34);
            this.AllThingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllThingsLabel.Name = "AllThingsLabel";
            this.AllThingsLabel.Size = new System.Drawing.Size(86, 17);
            this.AllThingsLabel.TabIndex = 99;
            this.AllThingsLabel.Text = "All things list";
            // 
            // TeamThingsList
            // 
            this.TeamThingsList.FormattingEnabled = true;
            this.TeamThingsList.Location = new System.Drawing.Point(1112, 66);
            this.TeamThingsList.Margin = new System.Windows.Forms.Padding(4);
            this.TeamThingsList.Name = "TeamThingsList";
            this.TeamThingsList.Size = new System.Drawing.Size(255, 24);
            this.TeamThingsList.TabIndex = 100;
            // 
            // TeamThingsLabel
            // 
            this.TeamThingsLabel.AutoSize = true;
            this.TeamThingsLabel.Location = new System.Drawing.Point(1017, 69);
            this.TeamThingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamThingsLabel.Name = "TeamThingsLabel";
            this.TeamThingsLabel.Size = new System.Drawing.Size(86, 17);
            this.TeamThingsLabel.TabIndex = 101;
            this.TeamThingsLabel.Text = "Team things";
            // 
            // robo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 676);
            this.Controls.Add(this.TeamThingsLabel);
            this.Controls.Add(this.TeamThingsList);
            this.Controls.Add(this.AllThingsLabel);
            this.Controls.Add(this.TeamStart);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.TextToTime);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.CicleRequestStart);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "robo";
            this.Text = "robo";
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
        private System.Windows.Forms.Button CicleRequestStart;
        private System.Windows.Forms.TextBox Temp;
        private System.Windows.Forms.Label TextToTime;
        private System.Windows.Forms.Button Team1;
        private System.Windows.Forms.Button TeamStart;
        private System.Windows.Forms.Label AllThingsLabel;
        private System.Windows.Forms.ComboBox TeamThingsList;
        private System.Windows.Forms.Label TeamThingsLabel;
    }
}

