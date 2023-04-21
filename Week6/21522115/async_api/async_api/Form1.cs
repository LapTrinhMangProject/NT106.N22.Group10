using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_api
{
    public partial class Form1 : Form
    {
        class TodoItems
        {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }
        }
        class PostItem
        {
            public int PostID { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string  email { get; set; }
            public string body { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        static async Task<string> get_json(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage get_data = await httpClient.GetAsync(url);
            string content = await get_data.Content.ReadAsStringAsync();
            return content;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_1.SelectedIndex != -1)
            {
                Call.Enabled = true;
            }
        }

        private async void Call_Click(object sender, EventArgs e)
        {
            var call_api = get_json(cb_1.SelectedItem.ToString());
            var content = await call_api;
            if (cb_1.SelectedItem.ToString() == "https://jsonplaceholder.typicode.com/posts/1/comments")
            {
                List<PostItem> postList = JsonConvert.DeserializeObject<List<PostItem>>(content);

                foreach (PostItem item in postList)
                {
                    richTextBox1.AppendText("PostID: " + item.PostID.ToString() + '\n');
                    richTextBox1.AppendText("id: " + item.id.ToString() + '\n');
                    richTextBox1.AppendText("name: " + item.name.ToString() + '\n');
                    richTextBox1.AppendText("email: " + item.email.ToString() + '\n');
                    richTextBox1.AppendText("body: " + item.body.ToString() + '\n');
                    richTextBox1.AppendText("\n");
                }
            }
            else
            {
                List<TodoItems> todoList = JsonConvert.DeserializeObject<List<TodoItems>>(content);

                foreach (TodoItems item in todoList)
                {
                    richTextBox1.AppendText("UserID: " + item.UserId.ToString() + '\n');
                    richTextBox1.AppendText("Id: " + item.Id.ToString() + '\n');
                    richTextBox1.AppendText("Title: " + item.Title.ToString() + '\n');
                    richTextBox1.AppendText("Completed: " + item.Completed.ToString() + '\n');
                    richTextBox1.AppendText("\n");
                }
            }
        }

        private void call_bt_Load(object sender, EventArgs e)
        {
            Call.Enabled = false;
            cb_1.Items.Add("https://jsonplaceholder.typicode.com/todos");
            cb_1.Items.Add("https://jsonplaceholder.typicode.com/posts/1/comments");
        }
    }
}
