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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string getHTML(string szURL)
        {

            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(szURL);
                // Get the response. 
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server. 
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access. 
                StreamReader reader = new StreamReader(dataStream);
                // Read the content. 
                string responseFromServer = reader.ReadToEnd();
                // Close the response. 
                response.Close();
                return responseFromServer;
            }
            catch
            {
                return szURL + " didn’t send any data.";
            }
           
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            string URL = URLBar.Text;
            richTextBox1.Text = getHTML(URL);

        }

        private void URLBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
