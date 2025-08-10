namespace Abstract;

public class FixedDiscountStrategy : PricingStrategy
{
    private readonly decimal _amount;
    public FixedDiscountStrategy(decimal amount)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
        _amount = amount;
    }

    public override decimal Calculate(decimal subtotal)
    {
        if (subtotal <= 0) throw new ArgumentOutOfRangeException(nameof(subtotal));
        decimal result = subtotal - _amount;
        return result < 0 ? 0 : decimal.Round(result, 2);
    }
}