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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(tb_input.Text);
            int[] numNums = num.ToString().Select(o => int.Parse(o.ToString())).ToArray();
            
            // нужно написать функцию проверки двух бинарных чисел
            // ну или проверять только по разрядам
            if ( numNums.Length < 5)
            {
                double sum = 0;
                for (int i = numNums.Length - 1; i >= 0; i--)
                {
                    Array.Reverse(numNums);
                    if (numNums[i] == 1)
                    {
                        sum += Math.Pow(2, i);
                    }
                }
                //bool_l.Content = sum.ToString();
                
                if (sum % 15 == 0)
                {
                    bool_l.Content = "Да";
                }
                else
                {
                    bool_l.Content = "Нет";
                }  
            }
            else
            {
                bool_l.Content = "Число не соответствует условию";
            }
        }
    }
}
