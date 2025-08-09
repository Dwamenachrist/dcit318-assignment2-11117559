namespace Inheritance;
public class CreditCardPayment : PaymentMethod
{
	public override void Process(decimal amount)
	{
		Console.WriteLine($"Charging card GHC {amount:0.00} (+2% fee)");
	}
}