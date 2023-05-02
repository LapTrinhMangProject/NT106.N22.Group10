using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_Connection;

namespace Client
{
    public partial class Client_form : Form
    {
        public Client_form()
        {
            InitializeComponent();
        }
         Mess mess = new Mess();
        IPAddress ipAddress;
        TcpClient client = new TcpClient();
        NetworkStream stream;
        private void Form1_Load(object sender, EventArgs e)
        {
            send_button.Enabled = false;
        }
       

         void connect_buton_Click(object sender, EventArgs e)
        {
            
                ipAddress = IPAddress.Parse(IP_textbox.Text);
                client = new TcpClient();
            client.ReceiveBufferSize = 1048576;
            client.SendBufferSize = 1048576;
                client.Connect(ipAddress, Int32.Parse(port_textbox.Text));
            mess.sender_name = hostname_textbox.Text;
                stream = client.GetStream();
            Thread thread1 = new Thread(() => Client_listening(stream));
            thread1.IsBackground = true;
            thread1.Start();
            connect_buton.Enabled = false;
            connect_buton.Text = "Connected";
            send_bytes("00");
            send_button.Enabled = true;
           
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if (specific_client_check_box.Checked)
            {
                mess.recipient_name = list_client_listbox.SelectedItems[0].ToString();
                chat_listbox.Items.Add($"You to {mess.recipient_name}: {send_textbox.Text}");

                send_bytes("10", send_textbox.Text);
            }
            else
            {
                send_bytes("01", send_textbox.Text);
                chat_listbox.Items.Add($"You: {send_textbox.Text}");
            }
        }
        void send_bytes(string code,string text=null)
        {
            byte[] bytes;
            if (code == "11")
            {
                bytes = Encoding.UTF8.GetBytes("11");

            }
            else
            {
                mess.body = text;
                string data = code + JsonConvert.SerializeObject(mess);
                bytes = Encoding.UTF8.GetBytes(data);
            }
            byte[] header = BitConverter.GetBytes(bytes.Length);
            stream.Write(header, 0, header.Length);
              stream.Write(bytes, 0, bytes.Length);
        stream.Flush();
        }

        void Client_listening(NetworkStream stream)
        {
            Mess mess_from_server = new Mess();
            while (client.Connected) {
              
                    int bytes_read = 0;
                    byte[] header = new byte[4];
                    while (bytes_read < 4)
                    {
                        bytes_read += stream.Read(header, 0, header.Length);
                    }
                    int length = BitConverter.ToInt32(header, 0);
                    bytes_read = 0;
                    byte[] buffer = new byte[length];
                    while (bytes_read<length) 
                    {
                        bytes_read += stream.Read(buffer, bytes_read, length - bytes_read);
                    }
                    string data = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                    string code = data.Substring(0, 2);
                    switch (code)
                    {
                        case "01":
                            string json_data = data.Substring(2);
                            mess_from_server = JsonConvert.DeserializeObject<Mess>(json_data);
                            chat_listbox.Invoke(new Action(() =>
                            {
                                chat_listbox.Items.Add($"{mess_from_server.sender_name}: {mess_from_server.body}");
                            }));
                            break;
                        case "11":
                            List<Mess> list = JsonConvert.DeserializeObject<List<Mess>>(data.Substring(2));
                            foreach (Mess name in list)
                            {
                                if (name.sender_name == mess.sender_name)
                                    continue;
                                list_client_listbox.Invoke(new Action(() =>
                                {
                                    list_client_listbox.Items.Add(name.sender_name);
                                }));
                            }
                            break;
                        case "fs":
                            mess_from_server = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                            chat_listbox.Invoke(new Action(() =>
                            {
                                chat_listbox.Items.Add($"Ban nhan duoc file {mess_from_server.file.fileName} tu {mess_from_server.sender_name}");
                                chat_listbox.Items.Add("Noi dung:");

                            }));
                            for (int index_list = 0; index_list < mess_from_server.file.content.Count; index_list++)
                                chat_listbox.Invoke(new Action(() =>
                                {
                                    chat_listbox.Items.Add($"{mess_from_server.file.content[index_list]}");

                                }));
                            break;
                        case "ib":
                           
                            mess_from_server = JsonConvert.DeserializeObject<Mess>(data.Substring(2));
                            chat_listbox.Invoke(new Action(() =>
                            {
                                chat_listbox.Items.Add($"Ban nhan duoc hinh tu {mess_from_server.sender_name}");
                            }));
                            using (MemoryStream ms = new MemoryStream(mess_from_server.imageBytes))
                            {

                                pictureBox1.Invoke(new Action(() =>
                                {
                                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                  //  pictureBox1.BackColor = Color.White;
                                    pictureBox1.Image = Image.FromStream(ms);
                                }));
                            }
                            break;

                    
                }
            }
            }
        void request_update_clients()
        {
          
                list_client_listbox.Invoke(new Action(() =>
                {
                    list_client_listbox.Items.Clear();
                }));
                send_bytes("11");
            
        }
        static byte[] ImageToByte(System.Drawing.Image iImage)
        {
            MemoryStream mMemoryStream = new MemoryStream();
            iImage.Save(mMemoryStream, System.Drawing.Imaging.ImageFormat.Gif);
            return mMemoryStream.ToArray();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            request_update_clients();
        }

        private void send_file_button_Click(object sender, EventArgs e)
        {
            mess.file.content.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string code;
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);
                FileInfo fileInfor = new FileInfo(fileName);
                if (fileInfor.Extension == ".png" || fileInfor.Extension == ".jpg")
                {
                    code = "ib";
                    if (specific_client_check_box.Checked)
                    {
                        code = "is";
                        mess.recipient_name = list_client_listbox.SelectedItems[0].ToString();
                    }
                    
                    Bitmap image = new Bitmap(filePath);
                    mess.imageBytes = ImageToByte(image);
                  
                }
                else
                {
                    code = "fb";
                    if (specific_client_check_box.Checked)
                    {
                        code = "fs";
                        mess.recipient_name = list_client_listbox.SelectedItems[0].ToString();
                    }
                    FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
                    StreamReader reader = new StreamReader(file);
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                        mess.file.content.Add(line);
                    reader.Close();
                    file.Close();
                }
             
                    mess.file.fileName = fileName;
               send_bytes(code);
              
           
         
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
