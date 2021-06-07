using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace lab4
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void button_GET_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient newClient = new WebClient();
                Stream response = newClient.OpenRead(RichTextBox_URL.Text);
                newClient.DownloadFile(RichTextBox_URL.Text, RichTextBox_Dir.Text);

                StreamReader responseReader = new StreamReader(response);

                RichTextBox_Content.Text = responseReader.ReadToEnd();

                responseReader.Close();
                response.Close();
            }
            catch (Exception)
            {
                string Error = "Bạn phải nhập đẩy đủ đường link web và đường dẫn lưu file!!!\n";
                MessageBox.Show(Error, "Error");
            }
        }
    }
}
