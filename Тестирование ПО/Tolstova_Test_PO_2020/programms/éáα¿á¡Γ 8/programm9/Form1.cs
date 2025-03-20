using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm9
{
    public partial class Form1 : Form
    {
        public static int kol;
        public static double summ;
        public static int j = 1;
        public static double z;
        public static double x;
        public static double c;
        public static double average;
        public static int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            string abc = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя .,!?:;";


            char[] str_char = str.ToCharArray();

            char[] s = abc.ToCharArray();

            int i = 0;
            while (i < str.Length)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (str_char[i] == s[j])
                    {
                        x = x + 1;
                    }
                }
                i++;
            }
            if (x == str.Length)
            {
                textBox2.Text = "Текст написан только русскими буквами";
            }
            else
            {
                textBox2.Text = "Текст написан буквами разных алфавитов";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа определяет является ли заданный текст предложением русского языка (т.е. в него входят только русские буквы, знаки препинания и пробелы).");
        }
    }
}