﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zgadywanka
{
    public partial class Form1 : Form
    {
        int maks;
        int dbl;
        int fl;
        int skok = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbl = int.Parse(textBox1.Text);



            switch (fl)
            {
                case 10:
                    if (dbl > maks)
                        MessageBox.Show("za dużo");
                    else if (dbl < maks)
                        MessageBox.Show("za mało");
                    else
                        MessageBox.Show("zgadleś");
                    break;

                case 100:
                    if (dbl > maks)
                        MessageBox.Show("za dużo");
                    else if (dbl < maks)
                        MessageBox.Show("za mało");
                    else
                        MessageBox.Show("zgadłeś");
                    break;

                case 1000:
                    if (dbl > maks)
                        MessageBox.Show("za dużo");
                    else if (dbl < maks)
                        MessageBox.Show("za mało");
                    else
                        MessageBox.Show("zgadłeś");
                    break;

            }
            skok = skok + 10;
            progressBar1.Value = skok;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Random nowy = new Random();
            maks = nowy.Next(10);
            fl = 10;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Random nowy = new Random();
            maks = nowy.Next(100);
            fl = 100;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Random nowy = new Random();
            maks = nowy.Next(1000);
            fl = 1000;
        }
    }
}
