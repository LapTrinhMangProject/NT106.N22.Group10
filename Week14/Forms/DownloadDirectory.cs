using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentFTP;
using FluentFTP.Rules;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    internal class DownloadDirectory
    {
        public static string path = "";
        public static void setpath(string a)
        {
            path = a;
        } 
        public static void _DownloadDirectory()
        {
            Login.client = new FtpClient("ngovuminhdat.ddns.net", "dophuckien", "UIT@123", 21);
            Login.client.Connect();
            Login.client.DownloadFile(@"C:\Downloads\kien.zip", "/ Lab6 /rclone-v1.62.2-windows-amd64.zip");
        }
        public static async Task DownloadDirectoryAsync()
        {
            var token = new CancellationToken();
            // Tải xuống tệp tin bằng đồng bộ
            var client = new FtpClient("ngovuminhdat.ddns.net", "dophuckien", "UIT@123", 21);
            client.Connect();
            client.DownloadFile(@"C:\Downloads\rclone -v 1.62.2-windows-amd64.zip", "/path/on/server/rclone -v 1.62.2-windows-amd64.zip");
        }
    }
}
