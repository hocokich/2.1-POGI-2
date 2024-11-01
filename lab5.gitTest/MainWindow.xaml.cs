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

namespace lab5.gitTest
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
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result.Content = double.Parse(a.Text) + double.Parse(b.Text);
            }
            catch { }
        }


        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result.Content = double.Parse(a.Text) - double.Parse(b.Text);
            }
            catch { }
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result.Content = double.Parse(a.Text) * double.Parse(b.Text);
            }
            catch { }
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result.Content = double.Parse(a.Text) / double.Parse(b.Text);
            }
            catch { }
        }
    }
}
