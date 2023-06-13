using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using OpenPop.Pop3;
using OpenPop.Mime;
namespace Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now.AddDays(-2);
            DateTime end = DateTime.Now;
            using (var client = new ImapClient())
            {
                string email = txt_email.Text.ToString().Trim();
                string password = txt_password.Text.ToString().Trim();
                client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                client.Authenticate(email, password);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var query = SearchQuery.DeliveredAfter(start).And(SearchQuery.DeliveredBefore(end));
                var messages = inbox.Search(query);
                int recentCount = 0;
                int messageCount = inbox.Count;
                int recentDays = 2;
                for (int i = messageCount - recentDays; i < messageCount; i++)
                {
                    var message = inbox.GetMessage(i);
                    if (message.Date.DateTime > DateTime.Now.AddDays(-recentDays))
                    {
                        recentCount++;
                    }
                }
                List<ListViewItem> items = new List<ListViewItem>();
                foreach (var uid in messages)
                {
                    var message = inbox.GetMessage(uid);
                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);
                    ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(date);
                    items.Add(name);
                }

                listView_message.Items.AddRange(items.ToArray());

                txt_total.Text = listView_message.Items.Count.ToString();
                txt_recent.Text = recentCount.ToString();

                listView_message.Columns.Add("Email", 200);
                listView_message.Columns.Add("From", 100);
                listView_message.Columns.Add("Thời gian", 100);
                listView_message.View = View.Details;
                client.Disconnect(true);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_password.Text = "";
            txt_total.Text = "";
            txt_recent.Text = "";
            listView_message.Items.Clear();
        }
    }
}
