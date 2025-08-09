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