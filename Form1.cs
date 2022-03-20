using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическое_задание_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday;
            if (DateTime.TryParse(maskedTextBox1.Text, out birthday) == false)
            {
                MessageBox.Show("Ошибка в дате");
            }
            else
            {
                int age = DateTime.Today.Year - birthday.Year;
                if (birthday.Date > DateTime.Today.AddYears(-age)) age--;
                label1.Text = age.ToString();
                label1.Text = birthday.CompareTo(DateTime.Parse("01.01.1900")).ToString();
                if (age == 0)
                {
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                }
                if (birthday.CompareTo(DateTime.Parse("01.01.1900")) < 0)
                {
                    System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Вторая_мировая_война");
                }
                else if (age >= 18)
                {
                    System.Diagnostics.Process.Start("https://www.kinopoisk.ru");
                }
                else if (age <= 18)
                {
                    System.Diagnostics.Process.Start("https://pl.spb.ru");
                }
                
            }
        }
    }
}
