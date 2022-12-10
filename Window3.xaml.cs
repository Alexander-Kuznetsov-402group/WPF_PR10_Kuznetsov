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

namespace WPF_PF10_Kuznetsov
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
        }
    }
}
