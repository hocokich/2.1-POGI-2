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

namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triangle tr;
        Quad qd;

        Random rnd = new Random();

        //проверка на текущуюю фигуру
        int isTriangle = 0;
        
        public MainWindow()
        {
            InitializeComponent();

        }

        public class Point2D
        {
            //Атрибуты класса
            private int X;
            private int Y;
            //Конструктор класса
            public Point2D(int x, int y)
            {
                //this используется для однозначного указания на атрибуты класса так как
                //переменные имеют одинаковые имена
            this.X = x;
                this.Y = y;
            }

            //Методы для получения координат
            public int getX()
            {
                return X;
            }
            public int getY()
            {
                return Y;
            }
            //Методы для изменения координат
            public void addX(int x)
            {
                X += x;
            }
            public void addY(int y)
            {
                Y += y;
            }
        }
        class Triangle
        {
            //Атрибуты класса
            private Point2D p1;
            private Point2D p2;
            private Point2D p3;
            //Конструктор класса
            public Triangle(Point2D p1, Point2D p2, Point2D p3)
            {
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
            }
            public Point2D getP1()
            {
                return p1;
            }
            public Point2D getP2()
            {
                return p2;
            }
            public Point2D getP3()
            {
                return p3;
            }
            public void addX(int X)
            {
                p1.addX(X);
                p2.addX(X);
                p3.addX(X);
            }
            public void addY(int Y)
            {
                p1.addY(Y);
                p2.addY(Y);
                p3.addY(Y);
            }
        }
        public class Quad
        {
            //Атрибуты класса
            private Point2D p1;
            private Point2D p2;
            private Point2D p3;
            private Point2D p4;
            //Конструктор класса
            public Quad(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
            {
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
                this.p4 = p4;
            }
            public Point2D getP1()
            {
                return p1;
            }
            public Point2D getP2()
            {
                return p2;
            }
            public Point2D getP3()
            {
                return p3;
            }
            public Point2D getP4()
            {
                return p4;
            }
            public void addX(int X)
            {
                p1.addX(X);
                p2.addX(X);
                p3.addX(X);
                p4.addX(X);
            }
            public void addY(int Y)
            {
                p1.addY(Y);
                p2.addY(Y);
                p3.addY(Y);
                p4.addY(Y);
            }
        }


        public void DrawLine(Point2D p1, Point2D p2)
        {
            //Создание новой линии
            Line line = new Line();
            line.Stroke = Brushes.White;
            line.StrokeThickness = 3;
            //Установка координат линии из координат точек Point2D
            line.X1 = p1.getX();
            line.Y1 = p1.getY();
            line.X2 = p2.getX();
            line.Y2 = p2.getY();
            //Добавление линии в Canvas
            Scene.Children.Add(line);
        }

        public void DrawTriangle()
        {
            isTriangle = 1;

            sliderY.Value = tr.getP1().getY();
            sliderX.Value = tr.getP1().getX();

            //Отрисовка треугольника с помощью функции отрисовки линии
            DrawLine(tr.getP1(), tr.getP2());
            DrawLine(tr.getP2(), tr.getP3());
            DrawLine(tr.getP3(), tr.getP1());

        }
        public void DrawQuad()
        {
            isTriangle = 2;

            sliderY.Value = qd.getP1().getY();
            sliderX.Value = qd.getP1().getX();

            //Отрисовка прямоугольника с помощью функции отрисовки линии
            DrawLine(qd.getP1(), qd.getP2());
            DrawLine(qd.getP2(), qd.getP3());
            DrawLine(qd.getP3(), qd.getP4());
            DrawLine(qd.getP4(), qd.getP1());

        }


        private void point_Click(object sender, RoutedEventArgs e)
        {
            Scene.Children.Clear();

            if (UserX.Text == "" && UserY.Text == "")
            {   //Создание треугольника со случайными координатами
                Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
                Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
                Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
                tr = new Triangle(p1, p2, p3);
            }
            else
            {//Создание треугольника со случайными координатами
                Point2D p1 = new Point2D(Int32.Parse(UserX.Text), Int32.Parse(UserY.Text));
                Point2D p2 = new Point2D(Int32.Parse(UserX.Text)+5, Int32.Parse(UserY.Text));
                Point2D p3 = new Point2D(Int32.Parse(UserX.Text), Int32.Parse(UserY.Text)+5);

                tr = new Triangle(p1, p2, p3);
            }

            sliderX.IsEnabled = true;
            sliderY.IsEnabled = true;

            DrawTriangle();
        }
        private void triangle_Click(object sender, RoutedEventArgs e)
        {
            Scene.Children.Clear();

            if(UserX.Text == "" && UserY.Text == "")
            {   //Создание треугольника со случайными координатами
                Point2D p1 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
                Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
                Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
                tr = new Triangle(p1, p2, p3);
            }
            else
                {//Создание треугольника со случайными координатами
                Point2D p1 = new Point2D(Int32.Parse(UserX.Text), Int32.Parse(UserY.Text));
                Point2D p2 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
                Point2D p3 = new Point2D(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));

                tr = new Triangle(p1, p2, p3);
            }

            sliderX.IsEnabled = true;
            sliderY.IsEnabled = true;

            DrawTriangle();
        }
        private void quad_Click(object sender, RoutedEventArgs e)
        {
            Scene.Children.Clear();

            //Создание квадрата со случайными координатами
            int x = rnd.Next(0, (int)Scene.Width);
            int y = rnd.Next(0, (int)Scene.Height);

            int biasX = rnd.Next(0, 100);
            int biasY = rnd.Next(0, 100);

            if (UserX.Text == "" && UserY.Text == "")
            {
                //Создание прямоугольника со случайными координатами
                Point2D p1 = new Point2D(x, y);
                Point2D p2 = new Point2D(x + biasX, y);
                Point2D p3 = new Point2D(x + biasX, y + biasY);
                Point2D p4 = new Point2D(x, y + biasY);
                qd = new Quad(p1, p2, p3, p4);
            }
            else
            {
                //Создание прямоугольника c пользовательскими координатами
                Point2D p1 = new Point2D(Int32.Parse(UserX.Text), Int32.Parse(UserY.Text));
                Point2D p2 = new Point2D(Int32.Parse(UserX.Text) + biasX, Int32.Parse(UserY.Text));
                Point2D p3 = new Point2D(Int32.Parse(UserX.Text) + biasX, Int32.Parse(UserY.Text) + biasY);
                Point2D p4 = new Point2D(Int32.Parse(UserX.Text), Int32.Parse(UserY.Text) + biasY);
                qd = new Quad(p1, p2, p3, p4);
            }

            sliderY.IsEnabled = true;
            sliderX.IsEnabled = true;

            DrawQuad();
        }
        private void square_Click(object sender, RoutedEventArgs e)
        {
            Scene.Children.Clear();

            //Создание квадрата со случайными координатами
            int x = rnd.Next(0, (int)Scene.Width);
            int y = rnd.Next(0, (int)Scene.Height);

            int bias = rnd.Next(0, 100);

            if (UserX.Text == "" && UserY.Text == "")
            {
                //Создание квадрата со случайными координатами
                Point2D p1 = new Point2D(x, y);
                Point2D p2 = new Point2D(x + bias, y);
                Point2D p3 = new Point2D(x + bias, y + bias);
                Point2D p4 = new Point2D(x, y + bias);
                qd = new Quad(p1, p2, p3, p4);
            }
            else
            {
                //Создание квадрата c пользовательскими координатами
                Point2D p1 = new Point2D(Int32.Parse(UserX.Text), Int32.Parse(UserY.Text));
                Point2D p2 = new Point2D(Int32.Parse(UserX.Text) + bias, Int32.Parse(UserY.Text));
                Point2D p3 = new Point2D(Int32.Parse(UserX.Text) + bias, Int32.Parse(UserY.Text) + bias);
                Point2D p4 = new Point2D(Int32.Parse(UserX.Text), Int32.Parse(UserY.Text) + bias);
                qd = new Quad(p1, p2, p3, p4);
            }

            sliderY.IsEnabled = true;
            sliderX.IsEnabled = true;

            DrawQuad();
        }

        private void SliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (isTriangle == 1)
            {
                double value = e.NewValue - e.OldValue;

                if (tr != null) tr.addX((int)value);

                if (qd != null) qd.addX((int)value);

                Scene.Children.Clear();

                //Отрисовка треугольника с помощью функции отрисовки линии
                DrawLine(tr.getP1(), tr.getP2());
                DrawLine(tr.getP2(), tr.getP3());
                DrawLine(tr.getP3(), tr.getP1());
            }
            if (isTriangle == 2)
            {
                double value = e.NewValue - e.OldValue;

                if (tr != null) tr.addX((int)value);

                if (qd != null) qd.addX((int)value);

                Scene.Children.Clear();

                DrawLine(qd.getP1(), qd.getP2());
                DrawLine(qd.getP2(), qd.getP3());
                DrawLine(qd.getP3(), qd.getP4());
                DrawLine(qd.getP4(), qd.getP1());
            }
        }
        private void SliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (isTriangle == 1)
            {
                double value = e.NewValue - e.OldValue;

                if (tr != null) tr.addY((int)value);

                if (qd != null) qd.addY((int)value);

                Scene.Children.Clear();

                //Отрисовка треугольника с помощью функции отрисовки линии
                DrawLine(tr.getP1(), tr.getP2());
                DrawLine(tr.getP2(), tr.getP3());
                DrawLine(tr.getP3(), tr.getP1());
            }
            if (isTriangle == 2)
            {
                double value = e.NewValue - e.OldValue;

                if (tr != null) tr.addY((int)value);

                if (qd != null) qd.addY((int)value);

                Scene.Children.Clear();

                DrawLine(qd.getP1(), qd.getP2());
                DrawLine(qd.getP2(), qd.getP3());
                DrawLine(qd.getP3(), qd.getP4());
                DrawLine(qd.getP4(), qd.getP1());
            }
        }

        
    }
}
