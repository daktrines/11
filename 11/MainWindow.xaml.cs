using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace _11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калион Екатерина Максимовна. 11 пр.  " +
                "Дана строка 'ahb acb aeb aeeb adcb axeb'. " +
                "Напишите регулярное выражение, которое" +
                "найдет строки ahb, acb, aeb." +
                "Дана строка 'aa a1a a22a a333a a4444a a55555a aba aca'." +
                "Напишите регулярное выражение, которое найдет строки, " +
                "в которых по краям стоят буквы 'a', а между" +
                "ними любое количество цифр(в том числе и ноль цифр, то есть строка 'aa')");
        }

        //Выход из программы
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Дана строка 'ahb acb aeb aeeb adcb axeb'.
        //Напишите регулярное выражение,
        //которое найдет строки ahb, acb, aeb.
        private void Расчитать1_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();
            Regex regex = new Regex("a.b");
            string s = "ahb, acb, aeb, aeeb, adcb, axeb";
            Rez1.Text = s;
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    ListBox1.Items.Add(matches[i]);
                }
            }
            else MessageBox.Show("Совпадений не найдено");
        }

        //Дана строка 'aa a1a a22a a333a a4444a a55555a aba aca'.
        //Напишите регулярное выражение,
        //которое найдет строки, в которых по краям стоят буквы 'a',
        //а между ними любое количество цифр(в том числе и ноль цифр, то есть строка 'aa')
        private void Расчитать2_Click(object sender, RoutedEventArgs e)
        {
            ListBox2.Items.Clear();
            Regex regex = new Regex("a\\d*a");
            string s = "aa, a1a, a22a, a333a, a4444a, a55555a, aba, aca";
            Rez2.Text = s;
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    ListBox2.Items.Add(matches[i]);
                }
            }
            else MessageBox.Show("Совпадений не найдено");
        }
    }
}
