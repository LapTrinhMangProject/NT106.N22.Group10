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
using MailKit.Net.Pop3;


namespace Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_password.Text = "";
            txt_total.Text = "";
            txt_recent.Text = "";
            listView_message.Items.Clear();
            listView_message.Columns.Clear();
        }

        private void bt_POP_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.ToString().Trim();
            string password = txt_password.Text.ToString().Trim();
            var client = new Pop3Client();
            using (client)
            {
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(email, password);

                int count = client.GetMessageCount();
                int countRecent = 0;

                for (int i = 0; i < count; i++)
                {
                    var message = client.GetMessage(i);
                    var strmess = message.From.ToString();
                    string[] row = { message.Subject, strmess, message.Date.ToString(), message.Body.ToString() };

                    var listViewItem = new ListViewItem(row);
                    listView_message.Items.Add(listViewItem);

                    DateTime now = message.Date.DateTime;
                    DateTime someDate = new DateTime(message.Date.Year, message.Date.Month, message.Date.Day);
                    TimeSpan timeSpan = now - someDate;
                    if (timeSpan.TotalDays <= 2) countRecent++;
                }
                txt_recent.Text = countRecent.ToString();
                txt_total.Text = count.ToString();
            }
                listView_message.Columns.Add("Email", 200);
                listView_message.Columns.Add("From", 100);
                listView_message.Columns.Add("Thời gian", 100);
                listView_message.View = View.Details;
        }
    }
}
