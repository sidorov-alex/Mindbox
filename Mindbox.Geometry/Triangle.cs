namespace Mindbox.Geometry;

public class Triangle : GeometryObject, IShape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double GetArea()
    {
        // Считаем площадь по формуле Герона.
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    /// <summary>
    /// Определяет, является ли треугольник прямоугольным.
    /// </summary>
    public bool IsRight()
    {
        var a2 = A * A;
        var b2 = B * B;
        var c2 = C * C;

        // Проверяем по теореме Пифагора.

        return (a2 + b2 == c2) || (a2 + c2 == b2) || (c2 + b2 == a2);
    }

    /// <summary>
    /// Определяет, существует ли треугольник.
    /// </summary>
    /// <remarks>Треугольник существует только тогда, когда сумма двух его сторон больше третьей.</remarks>
    public bool IsValid() => (A + B > C) && (A + C > B) && (B + C > A);

    public override string ToString() => $"Triangle ({A}, {B}, {C})" + (IsValid() ? "" : " [НЕ СУЩЕСТВУЕТ]");
}