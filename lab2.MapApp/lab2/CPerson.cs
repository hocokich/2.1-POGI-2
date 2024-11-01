﻿using GMap.NET.WindowsPresentation;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Device.Location;

namespace lab2
{
    internal class CPerson : CMapObject
    {
        PointLatLng point;
        GMapMarker marker;

        public CPerson(string title, string picName, PointLatLng location) : base(title)
        {
            this.point = location;

            marker = new GMapMarker(location)
            {
                Shape = new Image
                {
                    Width = 32, // ширина маркера
                    Height = 32, // высота маркера
                    ToolTip = title, // всплывающая подсказка
                    Source = new BitmapImage(new Uri("pack://application:,,,/pics/" + picName)) // картинка
                }
            };
        }

        public new double getDistance(PointLatLng point)
        {
            // точки в формате GMap.NET
            PointLatLng p2 = this.point;
            PointLatLng p1 = point;

            // точки в формате System.Device.Location
            GeoCoordinate c1 = new GeoCoordinate(p1.Lat, p2.Lng);
            GeoCoordinate c2 = new GeoCoordinate(p2.Lat, p2.Lng);

            // вычисление расстояния между точками в метрах
            double distance = c1.GetDistanceTo(c2);

            return distance;
        }

        public override PointLatLng getFocus()
        {
            return point;
        }

        public override GMapMarker getMarker()
        {
            return marker;
        }
    }
}