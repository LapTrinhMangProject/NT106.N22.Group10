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
using Newtonsoft.Json;
namespace _21521947_Lythuyettuan6_1
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        private async void geturl_Click(object sender, EventArgs e)
        {
            geturl.Enabled = false;
            var url = pasteURL.Text;
            var todoList = await GetTodoList(url);
            displayurl.Items.Clear();
            int count = 0;
            foreach (var task in todoList)
            {
                displayurl.Items.Add("userId: " + task.id);
                displayurl.Items.Add("id: " + count);
                displayurl.Items.Add("title: " + task.title);
                displayurl.Items.Add("completed: " + task.completed);
                displayurl.Items.Add("\n");
                count++;
            }
            geturl.Enabled = true;
        }

        private async Task<dynamic[]> GetTodoList(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<dynamic[]>(content);
        }
    }
}
