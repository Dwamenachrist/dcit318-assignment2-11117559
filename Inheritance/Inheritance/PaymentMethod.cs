namespace Inheritance;

public class PaymentMethod
{
    public virtual void Process(decimal amount)
    {
        Console.WriteLine($"Processing generic payment of GHC {amount:0.00}");
    }
}