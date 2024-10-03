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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void bt_whatIsIt_Click(object sender, RoutedEventArgs e)
        {
            // вообще без понятия, но история с трай кэтчами не про это задание
            // возможно это история с трай парсами
            string str = tb_input.Text.Trim();
            if(int.TryParse(str, out int i))
            {
                tbl_Otvet.Text = "1";
            }
            else if (str.Contains('.'))
            {
                str = str.Replace(".", "");
                if (str.All(Char.IsDigit))
                {
                    tbl_Otvet.Text = "2";
                }
                else
                {
                    tbl_Otvet.Text = "0";
                }
            }
            else if (str.All(Char.IsLetter))
            {
                tbl_Otvet.Text = "0";
            }
            else
            {
                tbl_Otvet.Text = "0";
            }

        }
    }
}
