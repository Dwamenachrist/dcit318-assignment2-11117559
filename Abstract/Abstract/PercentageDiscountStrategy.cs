namespace Abstract;

public class PercentageDiscountStrategy : PricingStrategy
{
    private readonly decimal _percent;
    public PercentageDiscountStrategy(decimal percent)
    {
        if (percent < 0 || percent > 100)
           throw new ArgumentOutOfRangeException("Percentage must be between 0 and 100");
        _percent = percent;
    }

    public override decimal Calculate(decimal subtotal)
    {
        if (subtotal <= 0) throw new ArgumentOutOfRangeException(nameof(subtotal));
        decimal discount = subtotal * (_percent / 100);
        decimal result = subtotal - discount;
        return result < 0 ? 0 : decimal.Round(result, 2);
    }
}