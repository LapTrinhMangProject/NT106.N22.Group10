using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net;
using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;
using MailKit.Search;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace form
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        private readonly ImapClient client;
        public ClientForm(ImapClient client)
        {
            this.client = client;
            InitializeComponent();
        }
        static ListBox fromListbox = new ListBox();
        static ListBox subjectListBox = new ListBox();
        static ListBox datetimeListbox = new ListBox();
        private void Client_Load(object sender, EventArgs e)
        {
            void DisplayForm()
            {
                Label number = new Label();
                number.Text = "#";
                Label from = new Label();
                from.Text = "From";
                Label subject = new Label();
                subject.Text = "Subject";
                Label datetime = new Label();
                datetime.Text = "Datetime";

            }
            void LoadEmail()
            {
                client.Inbox.Open(FolderAccess.ReadWrite);
                var uids = client.Inbox.Search(SearchQuery.NotSeen);
                int number = 1;
                foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = number.ToString();
                    listViewItem.SubItems.Add(message.From.ToString());
                    listViewItem.SubItems.Add(message.Subject.ToString());
                    listViewItem.SubItems.Add(message.Date.ToString());
                    listViewItem.Tag = uid;
                    listView1.Items.Insert(number - 1, listViewItem);
                    number++;


                }
            }
            DisplayForm();
            LoadEmail();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.X, e.Y);
            var row = info.Item.Index;
            var col = info.Item.SubItems.IndexOf(info.SubItem);
            var value = info.Item.SubItems[col].Text;
            if (row == 0 || row >= listView1.Items.Count)
                return;
            EmailForm email = new EmailForm((UniqueId)listView1.Items[row].Tag, client);
            email.ShowDialog();

        }

        private void sendmailButton_Click(object sender, EventArgs e)
        {
            LoginForm.sendForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm.clientForm.Close();
            LoginForm.loginForm.Show();
            client.Disconnect(true);
        }
    }
}
