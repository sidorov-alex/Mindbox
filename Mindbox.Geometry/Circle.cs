namespace Mindbox.Geometry;

public class Circle : GeometryObject, IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double GetArea() => Math.PI * Radius * Radius;

    public override string ToString() => $"Circle (R={Radius})";
}