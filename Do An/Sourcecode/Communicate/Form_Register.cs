using communicate_client_server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Communicate
{
    public partial class Form_Register : Form
    {
        string stringConnection = @"Data Source=databaselaptrinhmang.database.windows.net;Initial Catalog=API_football;User ID=laptrinhmang;Password=BJo8RxhgQvkD2jSBDK3S3LNvUpAH9n";
        Request requestUser;
        SqlConnection connection;
        SqlCommand command; 
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public Form_Register()
        {
            InitializeComponent();
        }

        private void bt_Dangky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_textbox.Text) || string.IsNullOrEmpty(pass_textbox.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //string hashPass = ComputeSha256Hash(pass_textbox.Text);
                string tentk = username_textbox.Text;
                string mk = pass_textbox.Text;
                string typeUser = "normal";
                string email = email_textbox.Text;
                string query = "Insert into users values ('" + tentk + "','" + mk + "', '" + typeUser + "', '" + email + "')";
                connection = new SqlConnection(stringConnection);
                connection.Open();
                string queryCheck = "SELECT COUNT(*) FROM users WHERE username = @username";
                command = new SqlCommand(queryCheck, connection);
                command.Parameters.AddWithValue("@username", tentk);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Tên tài khoản đã được đăng ký, vui lòng đăng ký bằng một tài khoản khác!");
                    return;
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("username", tentk);
                    command.Parameters.AddWithValue("password", mk);
                    command.Parameters.AddWithValue("typeUser", typeUser);
                    command.Parameters.AddWithValue("email", email);
                    command.ExecuteReader();
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                }
                this.Close();
                Client f1 = new Client();
                f1.Show();
            }
        }

        //private static string ComputeSha256Hash(string rawData)
        //{
        //  using (SHA256 sha256Hash = SHA256.Create())
        //  {
        //     // ComputeHash - returns byte array  
        //      byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
        //      StringBuilder builder = new StringBuilder();
        //      for (int i = 0; i < bytes.Length; i++)
        //      {
        //           builder.Append(bytes[i].ToString("x2"));
        //      }
        //      return builder.ToString();
       //   }
    }
}


