namespace Mindbox.Geometry;

/// <summary>
/// Геометрическая фигура на плоскости. 
/// </summary>
public interface IShape
{
    /// <summary>
    /// Подсчитывает площадь фигуры.
    /// </summary>
    double GetArea();
}