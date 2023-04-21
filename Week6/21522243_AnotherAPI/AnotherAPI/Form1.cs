using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace AnotherAPI
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void bt_GetAPI_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    var todos = await GetTodosAsync();
                    DisplayTodos(todos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private async Task<List<Todo>> GetTodosAsync()
        {
            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/comments");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Todo>>(content);
        }

        private void DisplayTodos(List<Todo> todos)
        {
            lv_Todos.Items.Clear();
            foreach (var todo in todos)
            {
                lv_Todos.Items.Add("postId: " + todo.postId + "\n");
                lv_Todos.Items.Add("id: " + todo.id + "\n");
                lv_Todos.Items.Add("name: " + todo.name + "\n");
                lv_Todos.Items.Add("email: " + todo.email + "\n");
                lv_Todos.Items.Add("body: " + todo.body + "\n");
                lv_Todos.Items.Add("");
            }
        }
        public class Todo
        {
            public int postId { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string body { get; set; }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
