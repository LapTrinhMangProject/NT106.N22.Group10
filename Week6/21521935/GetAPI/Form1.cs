using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GetAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void GetAPI_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            var content = await response.Content.ReadAsStringAsync();
            Todo[] todo_list = JsonConvert.DeserializeObject<Todo[]>(content);
            thongtintask.Items.Add("Thong tin tat ca cac task la:");
            int number_task = 1;
            foreach (var todo in todo_list)
            {
                thongtintask.Items.Add("Task "+number_task);
                thongtintask.Items.Add("User id: " + todo.id);
                thongtintask.Items.Add("Thong tin task: " + todo.title);
                thongtintask.Items.Add("Trang thai: "+ (todo.completed == true ? "Hoan thanh" : "chua hoan thanh"));
                thongtintask.Items.Add("");
                number_task++;
            }

        }
    }
}
