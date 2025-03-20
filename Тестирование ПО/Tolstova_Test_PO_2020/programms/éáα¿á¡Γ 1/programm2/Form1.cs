using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm2
{
    public partial class Form1 : Form
    {
        static string a;
        static string w;
        static int x;
        static int i;
        static int L;
        //static int q; в оригинале программы на Pascal была

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "";
            i = 0;
            a = textBox1.Text;
            L = a.Length;
            while (i < L)
            {
                x = (int)a[i] - 2;
                i = i + 1;
                w = w + (char)(x);
            }
            textBox2.Text = w;
            //textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "";
            i = 0;
            a = textBox1.Text;
            L = a.Length;
            while (i < L)
            {
                x = (int)a[i] + 2;
                i = i + 1;
                w = w + (char)(x);
            }
            textBox2.Text = w;
            //textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа шифрует символы на -2 по коду символа, а также производит дешифрование.");
        }
    }
}