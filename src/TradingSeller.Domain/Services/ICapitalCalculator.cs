namespace TradingSeller.Domain.Services;

public interface ICapitalCalculator
{
    decimal CalculateRequiredCapital(decimal price, decimal quantity);
}
