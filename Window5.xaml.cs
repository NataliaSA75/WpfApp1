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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_generator_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(tb_n.Text);
            int m = Convert.ToInt32(tb_m.Text);
            int[,] ints = new int[n, m];
            Random random = new Random();
            tbl_Otvet.Text = "";
            tbl_asc.Text = "";
            tbl_desc.Text = "";
            List<int> list = new List<int>();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = random.Next(-10, 10);
                    list.Add(ints[i, j]);
                    tbl_Otvet.Text += $"{ints[i, j]}, ";
                }
                tbl_Otvet.Text += "\n";
            }
            list.Sort();
            for(int i = 0;i < ints.GetLength(0); i++)
            {
                for(int j = 0;j < ints.GetLength(1); j++)
                {
                    int k = i * ints.GetLength(1) + j;
                    if (k < list.Count)
                    {
                        ints[i, j] = list[k];
                        tbl_desc.Text += $"{ints[i, j]}, ";
                    }
                }
                tbl_desc.Text += "\n";
            }
            list.Reverse();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    int k = i * ints.GetLength(1) + j;
                    if (k < list.Count)
                    {
                        ints[i, j] = list[k];
                        tbl_asc.Text += $"{ints[i, j]}, ";
                    }
                }
                tbl_asc.Text += "\n";
            }
        }
    }
}
