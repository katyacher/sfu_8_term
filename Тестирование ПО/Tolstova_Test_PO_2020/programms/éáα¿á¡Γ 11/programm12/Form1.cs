using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm12
{
    public partial class Form1 : Form
    {

        static string[] St = new string[20];
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
            MessageBox.Show("Данная программа определяет, является ли заданный текст арифметическим выражением без скобок (т.е. в него входят только числа и/или знаки операций +,-,*,/).");
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
                    while (i < S.Length && Convert.ToString(S[i]) != "+" && Convert.ToString(S[i]) != "-" && Convert.ToString(S[i]) != "/" && Convert.ToString(S[i]) != "*")
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
            i = 0;
            for (i = 0; i < St.Length; i++)
            {
                try
                {
                    double x;
                    x = Convert.ToDouble(St[i]);
                }
                catch (Exception)
                {
                    textBox2.Text = "Не является";
                    break;
                }
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Является";
            }
        }
    }
}
