namespace Prototype;
public class Color : IPrototype<Color>
{
    public ushort Red { get; set; }
    public ushort Green { get; set; }
    public ushort Blue { get; set; }

    public Color(ushort red, ushort green, ushort blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public static Color LightGray => new(217, 217, 217);

    public Color Clone()
    {
        return new Color(Red, Green, Blue);
    }
}
