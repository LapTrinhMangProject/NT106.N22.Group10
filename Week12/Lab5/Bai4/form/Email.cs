using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }
        readonly UniqueId uid;
        readonly ImapClient client;
        public EmailForm(UniqueId uid, ImapClient client)
        {
            this.uid = uid;
            this.client = client;
            InitializeComponent();
        }
        private void email_Load(object sender, EventArgs e)
        {

            var message = client.Inbox.GetMessage(uid);
            try
            {
                body.DocumentText = message.GetTextBody(MimeKit.Text.TextFormat.Html).ToString();
            }
            catch (NullReferenceException ex)
            {
                body.DocumentText = message.Body.ToString();

            }







        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
