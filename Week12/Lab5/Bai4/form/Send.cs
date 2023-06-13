using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }
        BodyBuilder bodyBuilder = new BodyBuilder();
        private void SendForm_Load(object sender, EventArgs e)
        {
            fromTextbox.Text = LoginForm.username;
            fromTextbox.Enabled = false;
            attachmentTextbox.Enabled = false;

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(LoginForm.username, LoginForm.username));
            message.To.Add(new MailboxAddress(nameTextbox.Text, toTextbox.Text));
            message.Subject = subjectTextbox.Text;
            if (htmlCheckbox.Checked)
                bodyBuilder.HtmlBody = bodyRichTextbox.Text;
            else
                bodyBuilder.TextBody = bodyRichTextbox.Text;
            message.Body = bodyBuilder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate(LoginForm.username, LoginForm.password);
                client.Send(message);
                client.Disconnect(true);
            }
            MessageBox.Show("Sent");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var attachmentPath = openFileDialog.FileName;
                bodyBuilder.Attachments.Add(attachmentPath);
                attachmentTextbox.Text = openFileDialog.FileName;
            }
        }
    }
}
