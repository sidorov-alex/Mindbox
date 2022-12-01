namespace Mindbox.Geometry.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 3.141593)]
    [InlineData(2, 12.566371)]
    [InlineData(10, 314.159265)]
    public void GetAreaEqual(double radius, double expected)
    {
        var c = new Circle(radius);

        var result = c.GetArea();

        Assert.Equal(expected, result, 6);
    }
}