using AbstractShapes;

var shapes = new List<Shape> { new Circle(3), new Rectangle(4, 5) };
foreach (var s in shapes) Console.WriteLine($"{s.GetType().Name} area: {s.GetArea():0.00}");

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();