using InheritanceAnimals;

var animals = new List<Animal> { new Animal(), new Dog(), new Cat() };
foreach (var a in animals) a.MakeSound();

Console.WriteLine("Press Enter to exit...");
Console.ReadLine();