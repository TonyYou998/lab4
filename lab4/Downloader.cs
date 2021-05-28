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

namespace lab4
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();
            
        }

        public Downloader(List<string> ListURLToDownload, string path) : this()
        {
            this.Show();
            float Total = ListURLToDownload.Count;
            WebClient downloader = new WebClient();

            Log.Text = "Folder to Download: " + path + Environment.NewLine;

            for (float i = 0; i < Total; i++)
            {
                float p = ((i+1) / Total) * 100;
                string link = ListURLToDownload[(int)i];
                progress.Value = (int) p;
                string filename = Path.GetFileName(new Uri(link).AbsolutePath);
                
                try
                {
                    downloader.DownloadFile(link, path + "/" + filename);
                    Log.Text +=  "[+] Downloaded: " + filename + Environment.NewLine;
                }
                catch
                {
                    Log.Text += "[X] Failed to download: " + filename + Environment.NewLine ;
                }
            }

            Log.Text += Environment.NewLine + "Đã download xong !!!";

        }
    }
}
