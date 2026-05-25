namespace TradingSeller.Domain.Services;

public class CapitalCalculator : ICapitalCalculator
{
    public decimal CalculateRequiredCapital(decimal price, decimal quantity)
        => price * quantity;
}
