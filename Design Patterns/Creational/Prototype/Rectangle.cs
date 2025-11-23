namespace Prototype;
public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Color Color { get; set; }

    public Rectangle(int width, int height, Color color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    public IShape Clone()
    {
        return new Rectangle(Width, Height, Color.Clone());
    }
}
