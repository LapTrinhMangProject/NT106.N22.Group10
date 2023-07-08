using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static FtpClient client;
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new FtpClient(serverTextbox.Text, usernameTextbox.Text, passwordTextbox.Text, 21);
            /*   if (!client.IsConnected)
               {
                   MessageBox.Show("Server Không tồn tại");
                   return;
               }
               if (!client.IsAuthenticated)
               {
                   MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                   return;
               }
               client.Connect();*/
            this.Hide();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();


        }
    }
}
