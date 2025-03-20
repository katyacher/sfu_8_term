using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm14
{
    public partial class Form1 : Form
    {

        static string[] St = new string[2];
        static string S;
        static int x;
        static int i;
        static int j;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа определяет начинается ли первое слово на ту же букву, которой оканчивается второе слово.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = textBox1.Text;
            i = 0;
            j = 0;
            while (i < S.Length)
            {
                try
                {
                    while (i < S.Length && Convert.ToString(S[i]) != " ")
                    {
                        St[j] = St[j] + S[i];
                        i = i + 1;
                    }
                }
                catch (Exception)
                {
                    break;
                }
                i = i + 1;
                j = j + 1;
            }

            if (St[0][0] == St[1][0])
            {
                textBox2.Text = "Начинается";
            }
            else
            {
                textBox2.Text = "Не начинается";
            }
        }
    }
}