using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDownloader downloader = new FileDownloader();
            downloader.DownloadComplete += new EventHandler(downloader_DownloadedComplete);
            downloader.ProgressChanged += new DownloadProgressHandler(downloader_ProgressChanged);
            downloader.Download("https://download-installer.cdn.mozilla.net/pub/firefox/releases/77.0.1/win64/en-GB/Firefox%20Setup%2077.0.1.exe");
        }

        static void downloader_ProgressChanged(object sender, DownloadEventArgs e)
        {
            Console.WriteLine("Progress " + e.PercentDone);
        }

        static void downloader_DownloadedComplete(object sender, EventArgs e)
        {
            System.Console.WriteLine("Download complete.");
        }
    }
}
