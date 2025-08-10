namespace AbstractShapes;
public class Rectangle : Shape
{
    private readonly double _width, _height;
    public Rectangle(double width, double height) { _width = width; _height = height; }
    public override double GetArea() => _width * _height;
}