using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using form;
namespace Bai4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = usernameTextbox.Text;
            var password = passwordTextbox.Text;
            ImapClient client = new ImapClient();
            client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
            client.Authenticate(email, password);
            if (client.IsAuthenticated)
            {
                ClientForm clientForm = new ClientForm(client);
                this.Hide();
                clientForm.Show();
                return;
            }
            else
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng");
            }


        }
    }
}
