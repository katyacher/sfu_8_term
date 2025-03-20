using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm4
{
    public partial class Form1 : Form
    {
        static string[] St = new string[20];
        static string S;
        static int k;
        static int i;
        static int j;
        static int L;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = textBox1.Text;
            L = S.Length;
            i = 0;
            j = 0;
            while (i < L)
            {
                while (i < L && Convert.ToString(S[i]) != " " && Convert.ToString(S[i]) != "." && Convert.ToString(S[i]) != "!" && Convert.ToString(S[i]) != "?" && Convert.ToString(S[i]) != ",")
                {
                    St[j] = St[j] + S[i];
                    i = i + 1;
                }
                i = i + 1;
                j = j + 1;
            }
            k = 0;
            listBox1.Items.Add(St[k]);
            for(i=1;i<j;i++)
            {
                listBox1.Items.Add(St[i]);
                if (St[i].Length>St[k].Length)
                {
                k=i;
                }
            }
            textBox2.Text = "самое длинное слово - " + St[k];
            numericUpDown1.Value = St[k].Length;
            k = 0;
            for (i = 1; i < j; i++)
            {
                if (St[i].Length < St[k].Length)
                {
                    k = i;
                }
            }
            textBox3.Text = "самое маленькое слово - " + St[k];
            numericUpDown2.Value = St[k].Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа находит самое длинное и самое короткое слово.");
        }
    }
}