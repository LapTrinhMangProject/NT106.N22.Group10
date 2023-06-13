using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit.Net.Smtp;
using System.Web;

namespace form
{
    public partial class replyForm : Form
    {
        public replyForm()
        {
            InitializeComponent();
        }
        public replyForm(UniqueId uid, ImapClient client)
        {
            this.client = client;
            this.uid = uid;
            InitializeComponent();
        }
        UniqueId uid;
        ImapClient client;
        string previousBodyMessage;
        BodyBuilder bodyBuilder = new BodyBuilder();
        string senderMessage;
        string recipientMessage;
        private void replyForm_Load(object sender, EventArgs e)
        {
            var message = client.Inbox.GetMessage(uid);
            try
            {
                previousBodyMessage = message.GetTextBody(MimeKit.Text.TextFormat.Html).ToString();
            }
            catch (NullReferenceException ex)
            {
                previousBodyMessage = message.TextBody.ToString();

            }
            bodyMessage.Text = previousBodyMessage;
            var temp = message.To.ToString().Split(' ');
            var temp1 = temp[temp.Length - 1];
            senderMessage = temp1.Replace("<", "").Replace(">", "");
            fromTexbox.Text = senderMessage;
            temp = message.From.ToString().Split(' ');
            temp1 = temp[temp.Length - 1];
            recipientMessage = temp1.Replace("<", "").Replace(">", "");
            toTexbox.Text = recipientMessage;
            fromTexbox.Enabled = false;
            toTexbox.Enabled = false;
            subjectTextbox.Text = "Re: " + message.Subject;
            subjectTextbox.Enabled = false;
            string replyBody = $"\n Vào ngày {message.Date} {message.From.ToString()} đã viết \n ";
            bodyMessage.Text = replyBody + previousBodyMessage;
            bodyMessage.Focus();
            bodyMessage.SelectionStart = 0;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(LoginForm.username, LoginForm.username));
            message.To.Add(new MailboxAddress(recipientMessage, recipientMessage));
            message.Subject = subjectTextbox.Text;
            bodyBuilder.TextBody = bodyMessage.Text;
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
    }
}
