using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentFTP;
using FluentFTP.Rules;

namespace Forms
{
    internal class DownloadDirectory
    {
        public static void _DownloadDirectory()
        {
            var client = new FtpClient("ngovuminhdat.ddns.net", "ngovuminhdat", "UIT@123", 21);
            client.Connect();
            // download a folder and all its files
            client.DownloadDirectory(@"C:\website\logs\", @"/public_html/logs", FtpFolderSyncMode.Update);
            // download a folder and all its files, and delete extra files on disk
            client.DownloadDirectory(@"C:\website\dailybackup\", @"/public_html/", FtpFolderSyncMode.Mirror);
        }
        public static async Task DownloadDirectoryAsync()
        {
            var token = new CancellationToken();
            // Tải xuống tệp tin bằng đồng bộ
            var client = new FtpClient("ngovuminhdat.ddns.net", "ngovuminhdat", "UIT@123", 21);
            client.Connect();
            client.DownloadFile(@"C:\Downloads\rclone -v 1.62.2-windows-amd64.zip", "/path/on/server/rclone -v 1.62.2-windows-amd64.zip");
        }
    }
}
