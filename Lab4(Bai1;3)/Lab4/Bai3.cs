using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        WebBrowser wb;
        public Bai3()
        {
            InitializeComponent();
        }
        public static string txt_add;

        private void load()
        {
            string url = tb_Address.Text;

            WebBrowser browser = new WebBrowser();
            browser.Width = panel1.Width;
            browser.Height = panel1.Height;
            panel1.Controls.Add(browser);
            browser.Navigate(url);
            txt_add = tb_Address.Text;
        }
        private void bt_Go_Click(object sender, EventArgs e)
        {
            load();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.ShowDialog();
        }

        private void bt_GotoSource_Click(object sender, EventArgs e)
        {
            Bai3_Source b3s = new Bai3_Source();
            b3s.Show();
        }
        private void DownloadImages(HtmlAgilityPack.HtmlDocument doc, string saveDirectory)
        {
            HtmlNodeCollection imgNodes = doc.DocumentNode.SelectNodes("//img[@src]");
            if (imgNodes != null)
            {
                WebClient client = new WebClient();
                foreach (HtmlNode imgNode in imgNodes)
                {
                    string imgUrl = imgNode.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(imgUrl))
                    {
                        string fileName = Path.GetFileName(imgUrl);
                        string savePath = Path.Combine(saveDirectory, fileName);
                        try
                        {
                            client.DownloadFile(imgUrl, savePath);
                        }
                        catch (WebException ex)
                        {
                            MessageBox.Show("Error download " + imgUrl + ": " + ex.Message);
                        }
                    }
                }
            }
        }

        private void DownloadLinkedFiles(HtmlAgilityPack.HtmlDocument doc, string baseUrl, string saveDirectory)
        {
            HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes("//a[@href]");
            if (linkNodes != null)
            {
                WebClient client = new WebClient();
                foreach (HtmlNode linkNode in linkNodes)
                {
                    string linkUrl = linkNode.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(linkUrl))
                    {
                        string absoluteUrl = new Uri(new Uri(baseUrl), linkUrl).AbsoluteUri;
                        string fileName = Path.GetFileName(absoluteUrl);
                        string savePath = Path.Combine(saveDirectory, fileName);
                        try
                        {
                            client.DownloadFile(absoluteUrl, savePath);

                        }
                        catch (WebException ex)
                        {
                            MessageBox.Show("Error download " + linkUrl + ": " + ex.Message);
                        }
                    }
                }
            }
        }


        private void SaveHtmlToFile(string url, string filePath)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                DownloadImages(doc, filePath);
                DownloadLinkedFiles(doc, url, filePath);
                doc.Save(filePath);

                MessageBox.Show("HTML file downloaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving HTML file: " + ex.Message);
            }
        }

        private void bt_Download_Click(object sender, EventArgs e)
        {
            string html = txt_add;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML Files (*.html)|*.html";
            saveFileDialog1.Title = "Save downloaded HTML file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                SaveHtmlToFile(html,saveFileDialog1.FileName);
            }
        }
    }
}
