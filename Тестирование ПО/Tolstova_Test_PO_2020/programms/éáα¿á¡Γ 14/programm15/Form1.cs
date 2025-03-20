using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа зашифровывает введенную с клавиатуры строку, поменяв местами первый символ со вторым, третий с четвертым и т. д. А также дешифрует");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string S = textBox1.Text;
            char[] crypto = S.ToCharArray();

            for (int i = 0; i < crypto.Length; i = i+2)
            {
                try
                {
                    char a1 = crypto[i];
                    crypto[i] = crypto[i + 1];
                    crypto[i + 1] = a1;
                }
                catch (Exception)
                {
                    break;
                }
            } 

            string str = "";
            for (int i = 0; i < crypto.Length; i++)
            {
                str = str + crypto[i].ToString();
            } 
            textBox2.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string S = textBox1.Text;
            char[] crypto = S.ToCharArray();

            for (int i = 0; i < crypto.Length; i = i + 2)
            {
                try
                {
                    char a1 = crypto[i];
                    crypto[i] = crypto[i + 1];
                    crypto[i + 1] = a1;
                }
                catch (Exception)
                {
                    break;
                }
            }

            string str = "";
            for (int i = 0; i < crypto.Length; i++)
            {
                str = str + crypto[i].ToString();
            }
            textBox2.Text = str;
        }
    }
}
