using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }
        readonly UniqueId uid;
        readonly ImapClient client;
        public Email(UniqueId uid, ImapClient client)
        {
            this.uid = uid;
            this.client = client;
            InitializeComponent();
        }
        private void email_Load(object sender, EventArgs e)
        {
            var message = client.Inbox.GetMessage(uid);
            body.DocumentText = message.TextBody.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
