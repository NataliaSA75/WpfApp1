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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private bool IsAllEqual(int i)
        {
            int lastDigit = i % 10;

            while (i > 9 && ((i /= 10) % 10) == lastDigit) ;

            return i == lastDigit;
        }

        private void bt_Otvet_Click(object sender, RoutedEventArgs e)
        {
            int[] arr = new int[] { 1, 1, 22, 77, 2, 22, 3, 34, 64, 90, 4444, 567 };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 10 || IsAllEqual(arr[i]))
                {
                    sb.Append($"{arr[i]}, ");
                }
            }
            tbl_Otvet.Text = sb.ToString();
        }
    }
}
