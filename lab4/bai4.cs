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

    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
            WebBrowser.Navigate("https://google.com");
        }
        private void urlbar_enter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                string url = URLBar.Text;
                if (checkURLValid(url))
                {
                    WebBrowser.Navigate(url);
                }    
                else
                    MessageBox.Show("URL không hợp lệ, URL phải bắt đầu bằng http hoặc https !");
            }
        }


        private string getHTML(string szURL)
        {

            WebRequest request = WebRequest.Create(szURL);

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            response.Close();
            return responseFromServer;
        }


        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            Stream data;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!checkURLValid(URLBar.Text))
            {
                MessageBox.Show("URL không hợp lệ, URL phải bắt đầu bằng http hoặc https !");
                return;
            }

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                WebClient page = new WebClient();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(page.OpenRead(URLBar.Text),Encoding.UTF8);
                var arr = doc.DocumentNode.SelectNodes("//*");
                WebClient downloader = new WebClient();
                foreach(var i in arr)
                {
                    string link = "";
                    if (i.Attributes["href"] != null) {
                        link = i.Attributes["href"].Value;
                    }
                    if (i.Attributes["src"] != null)
                    {
                        link = i.Attributes["src"].Value;
                    }

                    if (checkextension(link))
                    {
                        if (!link.Contains("http") || !link.Contains("https"))
                        {
                            link = URLBar.Text + link;
                        }
                        string filename = Path.GetFileName(new Uri(link).AbsolutePath);
                        downloader.DownloadFile(link, fbd.SelectedPath + "/" + filename);
                        
                    }
                }

            }


            //byte[] bytes_response = Encoding.UTF8.GetBytes(response);
        }

        private bool checkextension(string link)
        {
            string[] extension = { ".jpg", ".png", ".webm", ".mp4", ".mp3", ".js", ".css", ".ico", ".jpeg"};
            return extension.Any(x => link.EndsWith(x));
        }

        public bool checkURLValid(string uriName)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }
        private void Sourcebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(URLBar.Text))
            {
                string response = getHTML(URLBar.Text);
                MessageBox.Show(response);
            }
        }



        private void Gobtn_Click(object sender, EventArgs e)
        {
            string url = URLBar.Text;
            if (checkURLValid(url))
            {
                WebBrowser.Navigate(url);
            }
                
            else
                MessageBox.Show("URL không hợp lệ, URL phải bắt đầu bằng http hoặc https !");
        }
    }
}
