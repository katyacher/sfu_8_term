using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm11
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

        private void button1_Click(object sender, EventArgs e)
        {
            S = textBox1.Text;
            i = 0;
            j = 0;
            while (i <= S.Length)
            {
                try
                {
                    while (i <= S.Length && Convert.ToString(S[i]) != " " && Convert.ToString(S[i]) != "," && Convert.ToString(S[i]) != ".")
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
                    S = St[i];
                    if ((Convert.ToString(S)) == "больше" && S.Length > 0)
                    {
                        St[i] = ">";
                    }
                    if ((Convert.ToString(S)) == "меньше" && S.Length > 0)
                    {
                        St[i] = "<";
                    }
                    if ((Convert.ToString(S)) == "равно" && S.Length > 0)
                    {
                        St[i] = "=";
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }


            for (i = 0; i < St.Length; i++)
            {
                try
                {
                    textBox2.Text = textBox2.Text + " " + St[i];
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа заменяет все слова \"меньше\", \"больше\" и \"равно\" на их обозначения (\"<\",\">\",\"=\").");
        }
    }
}