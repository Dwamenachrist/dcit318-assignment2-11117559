namespace AbstractShapes;
public class Circle : Shape
{
    private readonly double _radius;
    public Circle(double radius) { _radius = radius; }
    public override double GetArea() => Math.PI * _radius * _radius;
}