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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
        private string getHTML(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string html = reader.ReadToEnd();
            return html;
        }

        private void btDOW_Click(object sender, EventArgs e)
        {
            WebClient myClient=new WebClient();
            Stream respone=myClient.OpenRead(tblink.Text);
            myClient.DownloadFile(tblink.Text,tbfolder.Text);
            richTextBox1.Text=getHTML(tblink.Text);
        }
    }
}
