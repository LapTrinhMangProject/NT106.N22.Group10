using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MailKit.Security;
using MimeKit;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //initializing
            var client = new SmtpClient();
            var SMTPHost = "smtp.gmail.com";
            client.Connect(SMTPHost, 465, true); // smtp host, port, use ssl.
            client.Authenticate("phihung21522115@gmail.com", textBox4.Text); // gmail account, app password
            //send email
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hung Phi Le", textBox1.Text));
            message.To.Add(new MailboxAddress("Hung Le Phi", textBox2.Text));
            message.Subject = "Test sending email feature";
            string body = "Hello teacher\nThis is my sending feature\nHave a nice day";
            message.Body = new TextPart("plain")

{
                Text = body
};
            client.Send(message);
            client.Disconnect(true);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
