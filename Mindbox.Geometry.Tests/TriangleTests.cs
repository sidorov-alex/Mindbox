using Mindbox.Geometry;

namespace Mindbox.Geometry.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(0, 0, 0, 0)]
    [InlineData(1, 1, 1, 0.433013)]
    [InlineData(3, 4, 5, 6)]
    [InlineData(20, 21, 29, 210)]
    [InlineData(100, 100, 100, 4330.127019)]
    public void GetAreaEqual(double a, double b, double c, double expected)
    {
        var t = new Triangle(a, b, c);

        var result = t.GetArea();

        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(1, 1, 1, false)]
    [InlineData(4, 5, 3, true)]
    [InlineData(8, 15, 17, true)]
    [InlineData(36, 77, 85, true)]
    [InlineData(2, 2, 3, false)]
    [InlineData(25, 12, 10, false)]
    public void IsRightTrueOrFalse(double a, double b, double c, bool expected)
    {
        var t = new Triangle(a, b, c);

        var result = t.IsRight();

        if (expected)
            Assert.True(result, $"Треугольник {t} должен быть прямоугольным.");
        else
            Assert.False(result, $"Треугольник {t} НЕ должен быть прямоугольным.");
    }
}