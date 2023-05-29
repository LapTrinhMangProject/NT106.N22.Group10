using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class UserResponse
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public List<User> data { get; set; }
            public Support support { get; set; }
        }

        public class User
        {
            public int id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string avatar { get; set; }
        }

        public class Support
        {
            public string url { get; set; }
            public string text { get; set; }
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "https://reqres.in/api/register";
            var call_api = get_json("https://reqres.in/api/users?page=1");
            var content = await call_api;
            var call_api1 = get_json("https://reqres.in/api/users?page=2");
            var content1 = await call_api;
            var response = JsonConvert.DeserializeObject<UserResponse>(content);
            var response1 = JsonConvert.DeserializeObject<UserResponse>(content1);
            foreach (var user in response.data)
            {
                comboBox1.Items.Add(user.email);
            }
            foreach(var user in response1.data)
            {
                comboBox1.Items.Add(user.email);
            }
        }
        static async Task<string> get_json(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage get_data = await httpClient.GetAsync(url);
            string content = await get_data.Content.ReadAsStringAsync();
            return content;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                string args_URL = "https://reqres.in/api/register";
                if (args_URL == null || args_URL.Length == 0)
                {
                    MessageBox.Show("Please specify the URI of the resource to retrieve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method early, since there is no URI to retrieve.
                }
                string args_pass = textBox3.Text;
                if(args_pass == null || args_pass.Length == 0)
                {
                    MessageBox.Show("Please specify the password of the resource to retrieve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method early, since there is no URI to retrieve.
                }
                // Define the data to send to the API
                var data = new { email = comboBox1.Text, password = args_pass };

                // Serialize the data to JSON format
                var json = JsonConvert.SerializeObject(data);

                // Create a new HttpRequestMessage with the API endpoint and the serialized data
                var request = new HttpRequestMessage(HttpMethod.Post, args_URL);
                request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                // Send the HTTP request and wait for the response
                var responses = await httpClient.SendAsync(request);

                // Read the response content as a string
                var responseContent = await responses.Content.ReadAsStringAsync();

                // Deserialize the response JSON to a dynamic object
                dynamic responseObject = JsonConvert.DeserializeObject(responseContent);

                // Get the token from the response object
                string token = responseObject["token"];
                string idd = responseObject["id"];
                // Display the token in the console
                richTextBox1.AppendText(token + '\n');
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
