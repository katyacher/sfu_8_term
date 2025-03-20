using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string S = textBox1.Text;
            char word = Convert.ToChar(textBox2.Text);
            char[] abc = S.ToCharArray();
            int j = 0;
            //textBox1.Text = "";
            int i = 0;
            while (i < S.Length)
            {
                if (abc[i] == word || abc[i] == (int)word)
                {
                    int x = i + 1;
                    listBox1.Items.Add("Символ "+ word + " находится на позиции " + x.ToString());
                    j = j + 1;
                }
                i = i + 1;
            }
            listBox1.Items.Add("Всего вхожений символа " + word + " " + j);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа определяет номера позиций и количество повторений заданного символа (или его кода) в строке.");
        }
    }
}
