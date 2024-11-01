using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace lb4.authorize
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            change_name.IsEnabled = false;
        }

        private void change_name_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.ShowDialog();
            string fname = dlg.FileName;

            pc.pcName.Content = name.Text;
            pc.pcStatus.Content = "Оффлайн";

            pc.Pic = new BitmapImage(new Uri(fname));
            //image1.Source = new BitmapImage(new Uri("pack://application:,,,/Resources/image.jpg"));

            if(name.Text == "admin")
            {
                pc.pcAbout.Content = "Грустный человек, \nжелающий поспать.";
                pc.pcStatus.Content = "Сдает лабы";
            }
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (name.Text.Length >= 3)
            {
                change_name.IsEnabled = true;
                return;
            }
            else change_name.IsEnabled = false;
        }
    }
}
