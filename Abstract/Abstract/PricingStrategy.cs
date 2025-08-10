namespace Abstract;
public abstract class PricingStrategy
{
    public abstract decimal Calculate(decimal subtotal);
}