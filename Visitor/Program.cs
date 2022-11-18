using Visitor;

Point p1 = (12, 2);
Point p2 = (23, 3);
Point p3 = (13, 432);

Circle circle1 = new Circle((10,10), 39);
Circle circle2 = new Circle((-2, 45), 3);

Triangle triangle1 = new Triangle((2,2), (3,3), (4,2));
Triangle triangle2 = new Triangle((4, 53), (-34, 12), (100, 100));

IExporter txtExporter = new TxtExporter();
IExporter jsonExporter = new JsonExporter();

string txt = txtExporter.ExportShapes(p1, p2, p3, circle1, circle2, triangle1, triangle2);
string json = jsonExporter.ExportShapes(p1,p2, p3, circle1, circle2, triangle1,triangle2);

File.WriteAllText("./shapes.txt", txt);
File.WriteAllText("./shapes.json", json);