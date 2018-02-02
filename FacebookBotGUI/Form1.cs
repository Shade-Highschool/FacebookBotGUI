using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookBotGUI
{
    public partial class Form1 : Form
    {
        FacebookClient fbClient;

        public Form1()
        {
            InitializeComponent();
            fbClient = new FacebookClient();
            this.AcceptButton = btnLogin;
        }
        private void FillListBox()
        {
            listBoxUsers.Items.Clear();
            Dictionary<string, string> dict = fbClient.GetOnlineUsers();

            foreach (var item in dict)
            {
                listBoxUsers.Items.Add(item);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            lblActiveStatus.Text = "Connecting..";
            if (await fbClient.LogIn(email, password))
            {
                FillListBox();
                lblActiveStatus.Text = "Connected successfully";
                lblUserName.Text = fbClient.ProfileName;
                lblUserId.Text = fbClient.ProfileId;
                lblUserId.Visible = true;
                lblUserName.Visible = true;

            }
            else
                lblActiveStatus.Text = "Connection unsuccessfull";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProfiles.Items.Clear();
            foreach (var item in listBoxUsers.SelectedItems)
            {
                listBoxProfiles.Items.Add(item);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!chckBoxCustomID.Checked)
            {
                foreach (KeyValuePair<string, string> item in listBoxProfiles.Items)
                {
                    for (int i = 0; i < numericUpDownMessageCount.Value; i++)
                    {
                        lblActiveStatus.Text = "Sending.." + i.ToString();
                        fbClient.SendMessage(item.Key, txtMessage.Text);
                    }
                }
            }
            else
            {
                for (int i = 0; i < numericUpDownMessageCount.Value; i++)
                {
                    lblActiveStatus.Text = "Sending.." + i.ToString();
                    fbClient.SendMessage(txtBoxCustomID.Text, txtMessage.Text);
                }
            }
            listBoxProfiles.Items.Clear();
            lblActiveStatus.Text = "Message sended";
        }
    }
}
