using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Security.Principal;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bai4
{
    public partial class Bai4_form : Form
    {
        public Bai4_form()
        {
            InitializeComponent();
        }
        List<UserData> _list = new List<UserData>();   
        private void label4_Click(object sender, EventArgs e)
        {

        }
        int index = 0; 
        private async void Bai4_form_Load(object sender, EventArgs e)
        {
            int page = 1;
            int totalPage;
            do
            {
                using (HttpClient client = new HttpClient()) 
                {
                    var response = await client.GetStringAsync($"https://reqres.in/api/users?page={page}");
                    UserData userData = JsonConvert.DeserializeObject<UserData>(response);
                    page = userData.page;
                    totalPage = userData.total_pages;
                    _list.Add(userData);
                    total_page_label.Text ="Total page: "+ userData.total_pages.ToString();
                    total_user_label.Text ="Total user: "+ userData.total.ToString();
                    user_per_page_label.Text="User/page: "+userData.per_page.ToString();
                    page_current_label.Text = "page: " + (index+1).ToString();
                    page++;
                 }
            }while(page<=totalPage);
            Show(_list[index]);

        }
        void Show(UserData userData)
        {
            page_current_label.Text="page: "+(index+1).ToString();  
            name1_label.Text = userData.data[0].first_name + " " + userData.data[0].last_name;
            gmail1_label.Text = userData.data[0].email;
            ShowImage(userData.data[0].avatar,pictureBox1);

            name2_label.Text = userData.data[1].first_name + " " + userData.data[1].last_name;
            gmail2_label.Text = userData.data[1].email;
            ShowImage(userData.data[1].avatar, pictureBox2);

            name3_label.Text = userData.data[2].first_name + " " + userData.data[2].last_name;
            gmail3_label.Text = userData.data[2].email;
            ShowImage(userData.data[2].avatar, pictureBox3);


            name4_label.Text = userData.data[3].first_name + " " + userData.data[3].last_name;
            gmail4_label.Text = userData.data[3].email;
            ShowImage(userData.data[3].avatar, pictureBox4);


            name5_label.Text = userData.data[4].first_name + " " + userData.data[4].last_name;
            gmail5_label.Text = userData.data[4].email;
            ShowImage(userData.data[4].avatar, pictureBox5);

            name6_label.Text = userData.data[5].first_name + " " + userData.data[5].last_name;
            gmail6_label.Text = userData.data[5].email;
            ShowImage(userData.data[5].avatar, pictureBox6);


            async void ShowImage(string url, PictureBox picturebox)
            {
                HttpClient client = new HttpClient();
                byte[] data = await client.GetByteArrayAsync(url);
                MemoryStream ms = new MemoryStream(data); 
                Bitmap bitmap = new Bitmap(ms);
                picturebox.Image = bitmap;  
                picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void forward_button_Click(object sender, EventArgs e)
        {
                index++;
            try
            {
                Show(_list[index]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("index out of range","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                index--;
            }
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            index--;
            try
            {
                Show(_list[index]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("index out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                index++;
            }
        }
    }
}
