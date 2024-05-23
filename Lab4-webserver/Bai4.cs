﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Lab4_webserver
{
    public partial class Bai4 : Form
    {
        private ProgressBar progressBar;
        private bool isProgressBarRunning = false;

        public Bai4()
        {
            InitializeComponent();
            _dsphim = new Dictionary<string, int>(); // Initialize the dictionary here

            foreach (Control control in panel1.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    groupBox.Click += GroupBox_Click;
                }
            }

        }

        public class Phim
        {
            public string TenPhim { get; set; }
            public string LinkPhim { get; set; }
            public string LinkImage { get; set; }
            public int Giave { get; set; }
        }

        private List<Phim> _PhimList;
        private int ygroupbox = 3;
        public Dictionary<string, int> _dsphim { get; set; }

        private void Bai4_Load(object sender, EventArgs e)
        {
           

            _PhimList = DeserializeFromFileJson<List<Phim>>(@"D:\HK2_2024\laptrinhmangcanban\Lab4-WEbserver\Lab4-webserver\Lab4-webserver\data.json");
            if (_PhimList != null && _PhimList.Count > 0)
            {
                

                foreach (var phim in _PhimList)
                {
                    GroupBox groupBox = new GroupBox
                    {
                        Location = new Point(4, ygroupbox),
                        Size = new Size(802, 181),
                        Text = ""
                    };
                    groupBox.Click += GroupBox_Click; 
                    panel1.Controls.Add(groupBox);
                    ygroupbox += 187;

                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(146, 164),
                        Location = new Point(5, 11),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    pictureBox.Load(phim.LinkImage);
                    groupBox.Controls.Add(pictureBox);

                    Label labelName = new Label
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = Color.LightCoral,
                        Location = new Point(177, 11),
                        Size = new Size(92, 32),
                        Text = phim.TenPhim
                    };
                    groupBox.Controls.Add(labelName);

                    Label labelLink = new Label
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        Location = new Point(180, 61),
                        Size = new Size(64, 25),
                        Text = phim.LinkPhim
                    };
                    groupBox.Controls.Add(labelLink);

                    // Populate the dictionary with movie name and price
                    _dsphim[phim.TenPhim] = phim.Giave;

                    
                }
            }

           
        }

        static T DeserializeFromFileJson<T>(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return default;
            }
        }

        private void GroupBox_Click(object sender, EventArgs e)
        {
            if (!isProgressBarRunning)
            {
                isProgressBarRunning = true;
                StartProgressBar();
            }
            GroupBox clickedGroupBox = (GroupBox)sender;
            string movieLink = "";

            foreach (Control control in clickedGroupBox.Controls)
            {
                if (control is Label label && label.Text.Contains("http"))
                {
                    movieLink = label.Text;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(movieLink)) 
            {
                ShowWeb showWeb = new ShowWeb
                {
                    ReceivedMessage = movieLink
                };
                showWeb.FormClosed += ShowWeb_FormClosed;
                showWeb.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy liên kết hợp lệ trong groupbox."); 
            }
        }
        private void ShowWeb_FormClosed(object sender, FormClosedEventArgs e)
        {
            isProgressBarRunning = false; 
            progressBar1.Value = 0;
        }
        private void StartProgressBar()
        {
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (sender, e) =>
            {
                if (progressBar1.Value < 100) 
                {
                    progressBar1.Value += 10; 
                }
                else
                {
                    timer.Stop();
                    isProgressBarRunning = false; 
                }
            };
            timer.Start(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Datve datve = new Datve
            {
                dsphim = _dsphim 
            };
            datve.Show();
            
        }
    }
}
