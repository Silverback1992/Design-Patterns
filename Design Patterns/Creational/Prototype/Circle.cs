namespace Prototype;
public class Circle : IShape
{
    public int Radius { get; set; }
    public Color Color { get; set; }

    public Circle(int radius, Color color)
    {
        Radius = radius;
        Color = color;
    }

    public IShape Clone()
    {
        return new Circle(Radius, Color);
    }
}
