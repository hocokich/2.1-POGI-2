using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace lab3.ClickerGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer;
        CController controller;

        int spawnRate = 100;
        double startTime;
        Size sceneSize;

        public MainWindow()
        {
            InitializeComponent();

            //Создание таймера
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);

            sceneSize.Height = Scene.Height;
            sceneSize.Width = Scene.Width;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Scene.Children.Clear();

            controller.update(0.1); //обновляем состояние контроллера

            startTime--;
            time.Content = "Время: " + startTime/100;
            score.Content = "Очки: " + controller.points;

            if (timer.IsEnabled)
            {
                controller.spawnObject();
                for (int i = 0; i < controller.count; i++)
                    Scene.Children.Add(controller.drawEllipses()[i]);
            }

            //Если время истекло
            if (startTime == 0)
            {
                timer.Stop();
                Scene.Children.Clear();

                startTime = 3000;
                score.Content = "Очки: 0";

                start.IsEnabled = true;
                lvl.IsEnabled = true;

                MessageBox.Show("Время кончилось!\n\nВаш результат: " + controller.points);
            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            lvl.IsEnabled = false;
            start.IsEnabled = false;

            timer.Start();

            startTime = (int)lvl.Value;

            controller = new CController(spawnRate, startTime, sceneSize);
        }

        private void click(object sender, MouseButtonEventArgs e)
        {
            if (!timer.IsEnabled)
                return;

            Point mPosition = new Point(e.GetPosition(Scene).X, e.GetPosition(Scene).Y);

            Ellipse el = controller.mouseClick(mPosition);

            if (el != null)
            {
                Scene.Children.Remove(el);
                listHitstMisses.Text += "+100 очков\n";
            }
            else listHitstMisses.Text += "-100 очков\n";
        }

        private void lvl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            time.Content = "Время: " + (int)lvl.Value/100;
        }
    }
}