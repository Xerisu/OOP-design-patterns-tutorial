using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IShape
    {
        string Export(IExporter exporter);
    }

    class Triangle : IShape
    {
        public Point Point1 { get; init; }
        public Point Point2 { get; init; }
        public Point Point3 { get; init; }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public string Export(IExporter exporter)
        {
            return exporter.ExportTriangle(this);
        }
    }
    class Point : IShape
    {
        public int X { get; init; }
        public int Y { get; init; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        } 
        public static implicit operator Point((int , int ) t) => new(t.Item1, t.Item2);

        public string Export(IExporter exporter)
        {
            return exporter.ExportPoint(this);
        }
    }
    class Circle : IShape
    {
        public Point Centre { get; init; }
        public int Radius { get; init; }

        public Circle(Point centre, int radius)
        {
            Centre = centre;
            Radius = radius;
        }

        public string Export(IExporter exporter)
        {
            return exporter.ExportCircle(this);
        }
    }
    
}

