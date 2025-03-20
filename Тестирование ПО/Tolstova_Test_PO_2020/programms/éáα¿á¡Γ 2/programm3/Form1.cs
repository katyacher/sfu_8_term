using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm3
{
    public partial class Form1 : Form
    {
        static double[,] a = new double[5, 3];
        static int i;
        static int j;
        static int m;
        static double max;

        public Form1()
        {
            InitializeComponent();
            i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i<=4)
            {
                a[i, 0] = (double)numericUpDown1.Value;
                a[i, 1] = (double)numericUpDown2.Value;
                a[i, 2] = (double)numericUpDown3.Value;
                m = i + 1;
                listBox1.Items.Add(m + " " + a[i, 0] + " " + a[i, 1] + " " + a[i, 2]);
                i = i + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            for (i = 0; i <= 4; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    textBox1.Text = a[i, j] + "  ";
                }
            }
            max = a[0, 0];
            for (i = 0; i <= 4; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        m = i;
                    }
                }
            }
            m = m + 1;
            textBox1.Text = "максимальный результат " + max + " номер спортсмена " + m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа нахожит победителя из 5 спортсменов, по наибольшему значению из трех введенных попыток.");
        }
    }
}