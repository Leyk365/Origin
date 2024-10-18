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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Color.Background = Brushes.Red;
            statusTextBlock.Text = "Фон сменен";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Color.Background = Brushes.Blue;
            statusTextBlock.Text = "Фон смен";
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Color.Background = Brushes.White;
            statusTextBlock.Text = "Фон сменен";

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крыжановский");
            statusTextBlock.Text = "Данные выведены";
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
    

}
