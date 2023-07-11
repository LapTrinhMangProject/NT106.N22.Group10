using FluentFTP;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        List<string> remoteSite = new List<string>();
        public string previousPath = "/";
        private void Dashboard_Load(object sender, EventArgs e)
        {
            remoteSite.Add(previousPath);
            LoadFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remoteSite.Remove(remoteSite.Last());
            LoadFile();

        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadFile()
        {
            listView.Items.Clear();
            int index = 0;
            foreach (var item in Login.client.GetListing(remoteSite.Last()))
            {
                switch (item.Type)
                {
                    case FtpObjectType.Directory:
                        ListViewItem tempItem = new ListViewItem(new[] { $"{item.Name}", $"{item.Type}" });
                        listView.Items.Insert(index, tempItem);
                        index++;
                        break;

                }

            }
            foreach (var item in Login.client.GetListing(remoteSite.Last()))
            {
                switch (item.Type)
                {
                    case FtpObjectType.File:
                        ListViewItem tempItem = new ListViewItem(new[] { $"{item.Name}", $"{item.Type}" });
                        listView.Items.Insert(index, tempItem);
                        index++;
                        break;
                }
            }
        }
        private void Dashboard_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var tempData = listView.SelectedItems[0];
            string newPath = tempData.SubItems[0].Text;
            if (remoteSite.Count == 1)
                remoteSite.Add(remoteSite[0] + newPath);
            else
            {
                remoteSite.Add($"{previousPath}/{newPath}");
                previousPath = remoteSite.Last();
            }
            LoadFile();
        }

        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            var tempData = listView.SelectedItems[0];
            string selectedItem = tempData.SubItems[0].Text;
            string user = Environment.UserName;
            FolderBrowserDialog folderPath = new FolderBrowserDialog();
            DialogResult dialogResult = folderPath.ShowDialog();
            string pathSelected;
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderPath.SelectedPath))
            {
                pathSelected = folderPath.SelectedPath;
                string fileSaveTo = pathSelected + "\\" + selectedItem;
                string remoteSelectedItemPath = remoteSite.Last() + "/" + selectedItem;
                Login.client.DownloadFile(fileSaveTo, remoteSelectedItemPath, FtpLocalExists.Overwrite, FtpVerify.Retry);
                MessageBox.Show($"Download thành công {selectedItem} ở đường dãn {pathSelected}");
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(localFilePath);
                string remoteFilePath = remoteSite.Last() + "/" + fileName;
                Login.client.UploadFile(localFilePath, remoteFilePath, (FtpRemoteExists)FtpVerify.Retry);
                LoadFile();
                MessageBox.Show("Upload thành công");
            }
        }
    }
}
