using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Communicate
{
    public partial class Form_FgtPass : Form
    {
        string randomCode;
        public static string to;
        string stringConnection = @"Data Source=databaselaptrinhmang.database.windows.net;Initial Catalog=API_football;User ID=laptrinhmang;Password=BJo8RxhgQvkD2jSBDK3S3LNvUpAH9n";
        Request requestUser;
        SqlConnection connection;
        SqlCommand command;
        public Form_FgtPass()
        {
            InitializeComponent();
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Email.Text)) MessageBox.Show("Vui lòng điền đầy đủ email!");
            else
            {
                string email = tb_Email.Text;
                connection = new SqlConnection(stringConnection);
                connection.Open();
                string queryCheck = "SELECT COUNT(*) FROM users WHERE email = @email";
                command = new SqlCommand(queryCheck, connection);
                command.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Không tìm thấy Email, vui lòng nhập lại email!");
                    return;
                }
                else
                {
                    ShareVariable.Email = email;
                    string from, pass, messbody;
                    Random random = new Random();
                    randomCode = (random.Next(999999)).ToString();
                    if (randomCode.Length != 6)
                    {
                        randomCode = new string('0', 6 - randomCode.Length) + randomCode;
                    }
                    ShareVariable.OTP = randomCode;
                    MailMessage message = new MailMessage();
                    to = tb_Email.Text.ToString();
                    from = "adoptionpet818@gmail.com";
                    pass = "nqrhurlflgaphvqr";
                    messbody = $"Your Password Reset Code is {randomCode}";
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messbody;
                    message.Subject = "Password Reset Code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Mã OTP đã được gửi tới email của bạn!");
                        this.Hide();
                        Form_Verify form_Verify = new Form_Verify();
                        form_Verify.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
