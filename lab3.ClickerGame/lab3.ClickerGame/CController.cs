using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace lab3.ClickerGame
{
    internal class CController //класс управляющий собираемыми объектами
    {
        List<CObject> objects; //список собираемых объектов
        double spawnRate; //время, между созданием собираемых объектов
        double time; //время с момента создания последнего собираемого объекта
        Random rng;
        //минимальное и максимальное время жизни собираемых объектов
        double minLifetime;
        double maxLifetime;
        //минимальный и максимальный размер собираемых объектов
        double minSpriteSize;
        double maxSpriteSize;
        Size sceneSize; //размер сцены
        public int points; //набранные очки

        public int count;//число объектов

        public CController(double spawnRate, double startTime, Size sceneSize)
        {
            rng = new Random();
            objects = new List<CObject>();
            this.spawnRate = spawnRate;
            time = startTime;
            this.sceneSize = sceneSize;
            points = 0;
            minLifetime = 1;
            maxLifetime = 10;

            minSpriteSize = 10;
            maxSpriteSize = 20;
        }

        public void spawnObject()
        {
            objects.Add(new CObject(new Point(rng.Next((int)sceneSize.Width), rng.Next((int)sceneSize.Height)), minSpriteSize, maxLifetime));

            //return objects[objects.Count - 1].getSprite();
        }
        public void destroyObject(CObject obj)
        {
            objects.Remove(obj);
        }
        public void update(double delta)
        {
            for (var i = 0; i < objects.Count; i++)
            {
                if (objects[i].updateLifetime(delta))
                {
                    destroyObject(objects[i]);
                    count = objects.Count;
                }
                else
                {
                    objects[i].sprite.Width += delta;
                    objects[i].sprite.Height += delta;

                    count = objects.Count;
                }
            }
        }
        public Ellipse mouseClick(Point mousePosition)
        {
            for (var i = 0; i < objects.Count; i++)
            {
                if (objects[i].isMouseOnObject(mousePosition))
                {
                    Ellipse el = objects[i].getSprite();

                    destroyObject(objects[i]);

                    points += 100;
                    return el;
                }
            }
            points += -100;
            return null;
        }

        public List<Ellipse> drawEllipses()
        {
            List<Ellipse> el = new List<Ellipse>();

            for (var i = 0; i < objects.Count; i++)
                el.Add(objects[i].getSprite());

            return el;
        }
    }
}
