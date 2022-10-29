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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mcListBox.Items.Add(textBox1.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            mcListBox.Items.Remove(textBox1.Text);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            mcListBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("resource/Диван.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("resource/Кресло.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("resource/Стол.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("resource/Торшер.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("resource/Кровать.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            myImage.Source = new BitmapImage(new Uri("resource/Стул.jpg", UriKind.Relative));
        }
    }
}
