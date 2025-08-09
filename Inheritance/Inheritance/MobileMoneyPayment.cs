namespace Inheritance;

public class MobileMoneyPayment : PaymentMethod
{
    public override void Process(decimal amount)
    { 
        Console.WriteLine($"Processing mobile money payment of GHC {amount:0.00} (flat GHC 0.50 fee)");
    }
}