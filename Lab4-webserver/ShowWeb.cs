using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_webserver
{
    public partial class ShowWeb : Form
    {
        public ShowWeb()
        {
            InitializeComponent();
        }

        private string url;

        public string ReceivedMessage
        {
            get { return url; }
            set
            {
                url = value;
                if (!string.IsNullOrEmpty(url))
                {
                    webView21.Source = new Uri(url);
                }
            }
        }

        private void ShowWeb_Load(object sender, EventArgs e)
        {

        }
    }
}
