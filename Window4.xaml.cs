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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tb_n.Text);
            int m = Convert.ToInt32(tb_m.Text);
            l_array.Content = "";
            Random rd = new Random();
            int[] ints = new int[n+m];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rd.Next(1,10);
                l_array.Content += $"{ints[i].ToString()}, ";
            }
            int start_first = ints[0];
            int end_first = ints[m-1];
            int start_second = ints[m];
            int end_second = ints[m+n-1];
            for (int i = 0; i < ints.Length; ++i)
            {
                if (i == 0)
                {
                    ints[i] = end_first;
                }
                if (i == m-1)
                {
                    ints[i] = start_first;
                }
                if(i == m)
                {
                    ints[i] = end_second;
                }
                if(i == n + m - 1)
                {
                    ints[i] = start_second;
                }
                l_sorted.Content += $"{ints[i]}, ";
            }
        }
    }
}
