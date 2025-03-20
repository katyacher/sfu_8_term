using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm1
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
            //listBox1.Items.Clear();
            S = textBox1.Text;
            //textBox1.Text = "";
            //numericUpDown1.Value = 0;
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
            for (i = 0; i < St.Length; i++)                                                                     //Провести рефакторинг фрагмента поиска слов в строке
            {                                                                                                   //в соответсвии со следующей спецификацией:
                try                                                                                             // FindWords(string s, string[] St, x)
                {                                                                                               //где FinWords - имя метода
                    S = St[i];                                                                                  //s - отдельные слова
                    if ((Convert.ToString(S[0])) == "t" || (Convert.ToString(S[0]) == "T") && S.Length > 0)     //St - массив слов
                    {                                                                                           //x - количество слов
                        listBox1.Items.Add(St[i]);
                        x = x + 1;
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
            numericUpDown1.Value = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа находит все слова начинающиеся с буквы t или T");
        }
    }
}