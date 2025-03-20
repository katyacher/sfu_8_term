using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm7
{
    public partial class Form1 : Form
    {
        static int p;
        static int q;
        static int i;
        static int j;
        static int m;
        static int k;
        static int c;
        static int[] S = new int[10];
        //static int[] N = new int[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            i = (int)numericUpDown1.Value;
            p = (int)numericUpDown2.Value;
            j = (int)numericUpDown3.Value;
            q = (int)numericUpDown4.Value;


            if (i < 0 || i > 9 || j < 0 || j > 9 || p < 0 || p > 5 || q < 0 || q > 5)
            {
                textBox1.Text = "Решения не существует";
            }
            else if (i%3 == j%3)
            {
                textBox1.Text = "Однозначного решения не существует";
            }
            else if (i + j > 9)
            {
                textBox1.Text = "Решения не существует";
            }
            else
            {
                m = 10 - (p + q);
                c = i;
                while (c <= 9)
                {
                    S[c] = p;
                    c = c + 3;
                }
                c = i - 3;
                while (c >= 1)
                {
                    S[c] = p;
                    c = c - 3;
                }
                c = j;
                while (c <= 9)
                {
                    S[c] = q;
                    c = c + 3;
                }
                c = j - 3;
                while (c >= 1)
                {
                    S[c] = q;
                    c = c - 3;
                }
                for (i = 1; i < 9; i++)
                {
                    if (S[i] != p && S[i] != q)
                    {
                        S[i] = m;
                        textBox1.Text = textBox1.Text + S[i];
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа получает ключ к сейфу, в котором 10 кубиков и сумма в трех соседних ячейках должна быть равна 10.");
        }
    }
}