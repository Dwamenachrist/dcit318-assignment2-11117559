using InterfacesMovables;

var movables = new List<IMovable> { new Car(), new Bicycle() };
foreach (var m in movables) m.Move();

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();