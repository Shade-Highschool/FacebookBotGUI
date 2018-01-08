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
            Dictionary<string, string> dict = fbClient.GetOnlineUsers();

            foreach (var item in dict)
            {
                listBoxUsers.Items.Add(item);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (fbClient.LogIn(email, password))
            {
                FillListBox();
                lblConnection.Text = "Connected successfully";
                lblUserName.Text = fbClient.ProfileName;
                lblUserId.Text = fbClient.ProfileId;
                lblUserId.Visible = true;
                lblUserName.Visible = true;

            }
            else
                lblConnection.Text = "Connection unsuccessfull";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
           KeyValuePair<string,string> pair = (KeyValuePair<string,string>)listBoxUsers.SelectedItem;
            txtId.Text = pair.Key;
            lblSelectedUser.Text = pair.Value;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            fbClient.SendMessage(txtId.Text, txtMessage.Text);
        }
    }
}
