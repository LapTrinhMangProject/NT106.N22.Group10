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
namespace form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static ClientForm clientForm = new ClientForm();
        public static EmailForm emailForm = new EmailForm();
        public static SendForm sendForm = new SendForm();
        public static string username;
        public static string password;
        public static LoginForm loginForm = new LoginForm();
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameTextbox.Text;
            password = passwordTextbox.Text;
            ImapClient client = new ImapClient();
            client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
            client.Authenticate(username, password);
            if (client.IsAuthenticated)
            {
                LoginForm.loginForm = this;
                LoginForm.loginForm.Hide();
                clientForm = new ClientForm(client);
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
