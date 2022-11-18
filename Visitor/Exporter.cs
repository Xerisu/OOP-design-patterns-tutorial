using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IExporter
    {
        string ExportShapes(params IShape[] shapes);
        string ExportCircle(Circle circle);
        string ExportTriangle(Triangle triangle);
        string ExportPoint(Point point);

    }
    internal class TxtExporter : IExporter
    {
        public string ExportCircle(Circle circle)
        {
            return $"Circle radius = {circle.Radius}, Circle centre = ({circle.Centre.X}, {circle.Centre.Y})";
        }

        public string ExportPoint(Point point)
        {
            return $"Point = ({point.X}, {point.Y})";
        }
        public string ExportTriangle(Triangle triangle)
        {
            return $"Triangle: A = ({triangle.Point1.X}, {triangle.Point1.Y}), B = ({triangle.Point2.X}, {triangle.Point2.Y}), C = ({triangle.Point3.X}, {triangle.Point3.Y})";
        }

        public string ExportShapes(params IShape[] shapes)
        {
            string result = "";
            foreach(var shape in shapes)
            {
                result += shape.Export(this) + "\n";
            }
            return result;
        }

        
    }
    internal class JsonExporter : IExporter
    {
        public string ExportCircle(Circle circle)
        {
            return $"{{\"radius\": {circle.Radius}, \"centre\": {ExportPoint(circle.Centre)}}}";
        }

        public string ExportPoint(Point point)
        {
            return $"{{\"x\": {point.X}, \"y\": {point.Y}}}";
        }

        public string ExportTriangle(Triangle triangle)
        {
            return $"{{\"a\": {ExportPoint(triangle.Point1)}, \"b\": {ExportPoint(triangle.Point2)}, \"c\": {ExportPoint(triangle.Point3)}}}";
        }
        public string ExportShapes(params IShape[] shapes)
        {
            string result = "[";
            foreach(var shape in shapes)
            {
                result += shape.Export(this) + ",";
            }
            return result[0..^1] + "]";
        }
    }
}
