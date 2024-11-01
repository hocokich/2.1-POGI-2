using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace lab3.ClickerGame
{
    internal class CObject
    {
        public Point position;
        public Size size;
        double lifetime;
        public Ellipse sprite;
        double pointsValue;

        public CObject(Point position, double size, double lifetime) //конструктор
        {
            this.position = position;
            this.size = new Size(size, size);
            this.lifetime = lifetime;
            //создание фигуры
            sprite = new Ellipse();
            //цвет фигуры
            sprite.Fill = Brushes.BlueViolet;
            sprite.StrokeThickness = 2;
            sprite.Stroke = Brushes.Black;
            //центрирование фигуры
            sprite.HorizontalAlignment = HorizontalAlignment.Center;
            sprite.VerticalAlignment = VerticalAlignment.Center;
            //размеры фигуры
            sprite.Width = this.size.Width;
            sprite.Height = this.size.Height;
            sprite.RenderTransform = new TranslateTransform(position.X, position.Y);
            //pointsValue = ((1 / this.size.Width) / lifetime) * 1000; //очковая стоимость обьекта
        }

        public bool isMouseOnObject(Point mousePosition)
        {
            var p = Point.Subtract(mousePosition, this.position).Length;
            if (p <= sprite.Width) return true;
            else return false;
        }
        public Ellipse getSprite()
        {
            return sprite;
        }
        public double getPointValue() 
        {
            return pointsValue;
        }
        public bool updateLifetime(double delta)
        {
            lifetime -= delta;

            if (lifetime < 1)
            {
                return true;
            }
            else return false;
        }
    }
}
