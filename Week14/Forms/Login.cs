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
using FluentFTP.Exceptions;
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
            try
            {
                client.Connect();
            }
            catch (FtpAuthenticationException ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show("Server không phản hổi hoặc không tồn tại", "Lỗi tìm Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
        }
    }
}
