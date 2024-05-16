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
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1=new Bai1();
            bai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 bai2=new Bai2();
            bai2.ShowDialog();
        }
    }
}
