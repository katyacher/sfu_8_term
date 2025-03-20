using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm5
{
    public partial class Form1 : Form
    {
        static string St;
        static string St1;
        static int i;
        static int j;
        static int k;
        static int n;
        static string m;
        static string[] s = new string[20];
        static int Kod;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            St = textBox1.Text;
            i = 0;
            while (i < St.Length)
            {
                while (i < St.Length && Convert.ToString(St[i]) != " " && Convert.ToString(St[i]) != "," && Convert.ToString(St[i]) != "!" && Convert.ToString(St[i]) != "?" && Convert.ToString(St[i]) != ".")
                {
                    s[j] = s[j] + St[i];
                    i = i + 1;
                }
                i = i + 1;
                j = j + 1;
            }
            for (i = 0; i < j; i++)
            {
                if (s[i].Length == 3)
                {
                    n = 0;
                    while (n < 3)
                    {
                    Kod=Kod+(char)s[i][n];
                    n=n+1;
                    }
                                  Kod=(int)Kod/3;
              textBox2.Text =textBox2.Text + (char)Kod + " ";
                }
                                    else
                    textBox2.Text =textBox2.Text + s[i] + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа заменяет все трехбуквенные слова на символ, который равен среднему значению этих трех букв.");
        }
    }
}