using Abstract;

decimal subtotal = 120;

var strategies = new List<PricingStrategy>
{
    new PercentageDiscountStrategy(10),
    new FixedDiscountStrategy(8),
};

foreach (var strategy in strategies)
{
    var finalPrice = strategy.Calculate(subtotal);
    Console.WriteLine($"Strategy: {subtotal:0.00} -> Final Price: {finalPrice:0.00} via {strategy.GetType().Name}");
}
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();