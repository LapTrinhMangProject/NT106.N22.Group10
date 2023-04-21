using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace GetAPI
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
        private async Task<List<Todo>> GetTodosAsync()
        {
            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Todo>>(content);
        }

        private void DisplayTodos(List<Todo> todos)
        {
            lv_Todos.Items.Clear();
            foreach (var todo in todos)
            {
                lv_Todos.Items.Add("UserId: " + todo.userId + "\n");
                lv_Todos.Items.Add("id: " + todo.Id + "\n");
                lv_Todos.Items.Add("Title: " + todo.Title + "\n");
                lv_Todos.Items.Add("Completed: " + todo.Completed + "\n");
                lv_Todos.Items.Add("");
            }
        }
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Todo
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
