using Mindbox.Geometry;

var objects = new Mindbox.Geometry.GeometryObject[] {
    new Circle(10),
    new Line(1, 2, 5, -3),
    new Triangle(4, 5, 3),
    new Triangle(4, 5, 2),
    new Triangle(1, 1, 10)
};

foreach (var obj in objects)
{
    Console.WriteLine(obj);

    if (obj is IShape shape)
    {
        Console.WriteLine($"\tArea = {shape.GetArea()}.");
    }

    if (obj is Triangle t)
    {
        Console.WriteLine("\tTriangle {0} right angled.", t.IsRight() ? "IS" : "IS NOT");
    }
}