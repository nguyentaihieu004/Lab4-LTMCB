using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4_webserver
{
    public partial class Datve : Form
    {
        public Datve()
        {
            InitializeComponent();
            this.Load += new EventHandler(Datve_Load); // Ensure Datve_Load is assigned
        }

        public Dictionary<string, int> dsphim { get; set; }
        private string[] sogheedachon;

        private void btxuatve_Click(object sender, EventArgs e)
        {
            sogheedachon = LayPhanTuDaChon();
            string vitringoi = string.Join("\n", sogheedachon);
            if (comboBox1.SelectedItem != null && dsphim.ContainsKey(comboBox1.Text))
            {
                MessageBox.Show(string.Format("Khách hàng: {2}\nPhim: {0}\nPhòng: {4}\nVị trí ngồi: {3}\nGiá: {1}",
                                              comboBox1.Text, dsphim[comboBox1.Text], txbhoten.Text, vitringoi, cbphong.Text));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim hợp lệ.");
            }
        }

        private string[] LayPhanTuDaChon()
        {
            List<string> phanTuDaChon = new List<string>();

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string phanTu = itemChecked.ToString();
                phanTuDaChon.Add(phanTu);
            }

            return phanTuDaChon.ToArray();
        }

        private void Datve_Load(object sender, EventArgs e)
        {
            if (dsphim != null)
            {
                foreach (string phim in dsphim.Keys)
                {
                    comboBox1.Items.Add(phim);
                }
            }
            else
            {
                MessageBox.Show("Danh sách phim trống.");
            }
        }
    }
}
