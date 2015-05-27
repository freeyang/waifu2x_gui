﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waifu2x_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text=ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string waifu;
            waifu = "-i "+textBox1.Text+" -j "+textBox2.Text+" --scale_ratio "+textBox3.Text+" --model_dir C:\\waifu2x\\waifu2x-converter\\models";
            System.Diagnostics.Process.Start("C:\\waifu2x\\waifu2x-converter\\waifu2x-converter.exe", @waifu);
        }
    }
}
