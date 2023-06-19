using communicate_client_server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicate
{
    public partial class Form_ResetPass : Form
    {
        string connectionString = SQL_Connection.Properties.Resources.SqlKey;

        Request requestUser;
        SqlConnection connection;
        SqlCommand command;
        public Form_ResetPass()
        {
            InitializeComponent();
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_RestPass.Text) || string.IsNullOrEmpty(tb_RestPass1.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu!");
            }
            else if (tb_RestPass.Text != tb_RestPass1.Text)
            {
                MessageBox.Show("Mật khẩu không đúng!");
            }
            else
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "UPDATE Users SET password = @password WHERE email = @email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", tb_RestPass.Text);
                    command.Parameters.AddWithValue("@email", ShareVariable.Email);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reset password successfully. Please back to log in!");
                        this.Hide();
                        Form1.client.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password.");
                    }
                }
            }
        }

        private void Form_ResetPass_Load(object sender, EventArgs e)
        {

        }
    }
}
