using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm10
{
    public partial class Form1 : Form
    {
        static string word1;
        static string word2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            word1 = textBox1.Text;
            word2 = textBox2.Text;
            string liter1 ="";
            string liter2 = "";
            liter1 = word1[0].ToString();
            int i = 0;
            while (i < word2.Length)
            {
                liter2 = word2[i].ToString();
                i++;
            }
            if (liter1 == liter2)
            {
                textBox3.Text = "Первая буква первого слова равна последней букве второго слова";
            }
            else
            {
                textBox3.Text = "Первая буква первого слова не равна последней букве второго слова";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа определяет верно ли, что первое слово начинается на ту же букву, которой оканчивается второе слово.");
        }
    }
}