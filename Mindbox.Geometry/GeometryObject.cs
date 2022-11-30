namespace Mindbox.Geometry;

public abstract class GeometryObject
{
    public override string ToString() => this.GetType().Name;

    /*Пример возможного абстрактного метода
    abstract void Draw(DrawContext dc)*/
}