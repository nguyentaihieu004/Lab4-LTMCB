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

namespace Lab4_webserver
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private string getHTML(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream =response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string html = reader.ReadToEnd();
            return html;
        }
        private void btGET_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=getHTML(tblink.Text);
        }
    }
}
