namespace Mindbox.Geometry;

public class Line : GeometryObject
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }

    public Line(float x1, float y1, float x2, float y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public override string ToString() => $"Line ({X1}, {Y1})-({X2}, {Y2})";
}
