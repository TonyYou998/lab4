using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class SourceHTMLShow : Form
    {
        public SourceHTMLShow()
        {
            InitializeComponent();
        }

        public SourceHTMLShow(string response) : this()
        {
            src_txt.Text = response;
        }
    }
}
