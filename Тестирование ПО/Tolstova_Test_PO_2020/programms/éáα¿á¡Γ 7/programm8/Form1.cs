using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm8
{
    public partial class Form1 : Form
    {
        public static double a;
        public static double b;
        public static double c;
        public static double average;
        public static int index;
        static float x = 0;
        static float z;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string str = textBox1.Text;

            string abc = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";


            char[] str_char = str.ToCharArray();

            char[] s = abc.ToCharArray();

            int i = 0;
            while (i<str.Length)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (str_char[i] == s[j])
                    {
                        x = x + 1;
                        listBox1.Items.Add(s[j]);
                    }
                }
                i++;
            }
            
            z = x/(float)str.Length;
            textBox2.Text = "Частотность русских букв = " + z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа определяет частоту использования букв русского алфавита в заданном тексте.");
        }

    }
}
