namespace Inheritance;
public class CryptoPayment: PaymentMethod
{
    public override void Process(decimal amount)
    {
        Console.WriteLine($"Processing crypto payment of GHC {amount:0.00} (flat GHC 1.00 fee)");
    }
}