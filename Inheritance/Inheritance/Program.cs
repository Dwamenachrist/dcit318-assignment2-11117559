using Inheritance;

var payments = new List<PaymentMethod>
{
    new MobileMoneyPayment(),
    new CreditCardPayment(),
    new CryptoPayment()
};

foreach (var payment in payments)
{
    payment.Process(100.00m);
}
Console.WriteLine("Press Enter to exit...");
Console.ReadLine();