using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа находит в введенном тексте количество всех гласных букв русского алфавита. Окончанием текста является знак \"!\"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            string str = textBox1.Text;

            string abc = "ауоыиэяюёе";


            char[] str_char = str.ToCharArray();

            char[] s = abc.ToCharArray();

            int i = 0;
            while (str_char[i] != Convert.ToChar("!"))
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (str_char[i] == s[j])
                        x = x + 1;
                }
                i++;
            }
            textBox2.Text = "количество глассных букв = " + x.ToString();
        }
    }
}
