namespace FacebookBotGUI
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.separatorVertical = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panelSend = new System.Windows.Forms.Panel();
            this.listBoxProfiles = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.numericUpDownMessageCount = new System.Windows.Forms.NumericUpDown();
            this.labelMessageCount = new System.Windows.Forms.Label();
            this.lblSendCounter = new System.Windows.Forms.Label();
            this.lblSended = new System.Windows.Forms.Label();
            this.txtBoxCustomID = new System.Windows.Forms.TextBox();
            this.chckBoxCustomID = new System.Windows.Forms.CheckBox();
            this.lblCustomID = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.loginPanel.SuspendLayout();
            this.panelSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessageCount)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(748, 0);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxUsers.Size = new System.Drawing.Size(265, 474);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "hacker-shade@seznam.cz";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.Location = new System.Drawing.Point(189, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 25);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: ";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginPanel.Controls.Add(this.separatorVertical);
            this.loginPanel.Controls.Add(this.separator);
            this.loginPanel.Controls.Add(this.lblUserId);
            this.loginPanel.Controls.Add(this.lblUserName);
            this.loginPanel.Controls.Add(this.lblActiveStatus);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.lblEmail);
            this.loginPanel.Controls.Add(this.lblStatus);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.txtEmail);
            this.loginPanel.Controls.Add(this.lblPassword);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(748, 128);
            this.loginPanel.TabIndex = 6;
            // 
            // separatorVertical
            // 
            this.separatorVertical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorVertical.Location = new System.Drawing.Point(164, 0);
            this.separatorVertical.Name = "separatorVertical";
            this.separatorVertical.Size = new System.Drawing.Size(5, 128);
            this.separatorVertical.TabIndex = 10;
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(194, 47);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(554, 10);
            this.separator.TabIndex = 9;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserId.Location = new System.Drawing.Point(190, 92);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(23, 20);
            this.lblUserId.TabIndex = 8;
            this.lblUserId.Text = "Id";
            this.lblUserId.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserName.Location = new System.Drawing.Point(189, 64);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(68, 25);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Name";
            this.lblUserName.Visible = false;
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActiveStatus.Location = new System.Drawing.Point(271, 20);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(151, 25);
            this.lblActiveStatus.TabIndex = 6;
            this.lblActiveStatus.Text = "Not connected";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(255, 143);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 36);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panelSend
            // 
            this.panelSend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelSend.Controls.Add(this.groupBoxSettings);
            this.panelSend.Controls.Add(this.listBoxProfiles);
            this.panelSend.Controls.Add(this.lblMessage);
            this.panelSend.Controls.Add(this.btnSend);
            this.panelSend.Controls.Add(this.txtMessage);
            this.panelSend.Controls.Add(this.lblProfile);
            this.panelSend.Location = new System.Drawing.Point(0, 131);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(359, 343);
            this.panelSend.TabIndex = 9;
            // 
            // listBoxProfiles
            // 
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.Location = new System.Drawing.Point(13, 29);
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.Size = new System.Drawing.Size(120, 108);
            this.listBoxProfiles.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(17, 169);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 185);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(335, 146);
            this.txtMessage.TabIndex = 4;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(17, 12);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(36, 13);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = "Profile";
            // 
            // numericUpDownMessageCount
            // 
            this.numericUpDownMessageCount.Location = new System.Drawing.Point(6, 32);
            this.numericUpDownMessageCount.Name = "numericUpDownMessageCount";
            this.numericUpDownMessageCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMessageCount.TabIndex = 10;
            this.numericUpDownMessageCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMessageCount
            // 
            this.labelMessageCount.AutoSize = true;
            this.labelMessageCount.Location = new System.Drawing.Point(6, 16);
            this.labelMessageCount.Name = "labelMessageCount";
            this.labelMessageCount.Size = new System.Drawing.Size(80, 13);
            this.labelMessageCount.TabIndex = 11;
            this.labelMessageCount.Text = "Message count";
            // 
            // lblSendCounter
            // 
            this.lblSendCounter.AutoSize = true;
            this.lblSendCounter.Location = new System.Drawing.Point(59, 55);
            this.lblSendCounter.Name = "lblSendCounter";
            this.lblSendCounter.Size = new System.Drawing.Size(13, 13);
            this.lblSendCounter.TabIndex = 12;
            this.lblSendCounter.Text = "0";
            // 
            // lblSended
            // 
            this.lblSended.AutoSize = true;
            this.lblSended.Location = new System.Drawing.Point(6, 55);
            this.lblSended.Name = "lblSended";
            this.lblSended.Size = new System.Drawing.Size(50, 13);
            this.lblSended.TabIndex = 13;
            this.lblSended.Text = "Sended: ";
            // 
            // txtBoxCustomID
            // 
            this.txtBoxCustomID.Location = new System.Drawing.Point(65, 107);
            this.txtBoxCustomID.Name = "txtBoxCustomID";
            this.txtBoxCustomID.Size = new System.Drawing.Size(132, 20);
            this.txtBoxCustomID.TabIndex = 14;
            // 
            // chckBoxCustomID
            // 
            this.chckBoxCustomID.AutoSize = true;
            this.chckBoxCustomID.Location = new System.Drawing.Point(9, 84);
            this.chckBoxCustomID.Name = "chckBoxCustomID";
            this.chckBoxCustomID.Size = new System.Drawing.Size(136, 17);
            this.chckBoxCustomID.TabIndex = 15;
            this.chckBoxCustomID.Text = "Send only to custom ID";
            this.chckBoxCustomID.UseVisualStyleBackColor = true;
            // 
            // lblCustomID
            // 
            this.lblCustomID.AutoSize = true;
            this.lblCustomID.Location = new System.Drawing.Point(3, 110);
            this.lblCustomID.Name = "lblCustomID";
            this.lblCustomID.Size = new System.Drawing.Size(56, 13);
            this.lblCustomID.TabIndex = 16;
            this.lblCustomID.Text = "Custom ID";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.lblCustomID);
            this.groupBoxSettings.Controls.Add(this.labelMessageCount);
            this.groupBoxSettings.Controls.Add(this.chckBoxCustomID);
            this.groupBoxSettings.Controls.Add(this.numericUpDownMessageCount);
            this.groupBoxSettings.Controls.Add(this.txtBoxCustomID);
            this.groupBoxSettings.Controls.Add(this.lblSendCounter);
            this.groupBoxSettings.Controls.Add(this.lblSended);
            this.groupBoxSettings.Location = new System.Drawing.Point(139, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(208, 134);
            this.groupBoxSettings.TabIndex = 17;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1013, 474);
            this.Controls.Add(this.panelSend);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.listBoxUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panelSend.ResumeLayout(false);
            this.panelSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMessageCount)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblActiveStatus;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label separatorVertical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ListBox listBoxProfiles;
        private System.Windows.Forms.Label labelMessageCount;
        private System.Windows.Forms.NumericUpDown numericUpDownMessageCount;
        private System.Windows.Forms.Label lblSended;
        private System.Windows.Forms.Label lblSendCounter;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label lblCustomID;
        private System.Windows.Forms.CheckBox chckBoxCustomID;
        private System.Windows.Forms.TextBox txtBoxCustomID;
    }
}

