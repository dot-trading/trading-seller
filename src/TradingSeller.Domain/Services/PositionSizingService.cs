namespace TradingSeller.Domain.Services;

public class PositionSizingService : IPositionSizingService
{
    public decimal CalculateQuantity(decimal capital, decimal entryPrice, decimal riskPercent)
    {
        if (entryPrice <= 0 || riskPercent <= 0) return 0;
        var riskAmount = capital * riskPercent / 100m;
        return riskAmount / entryPrice;
    }
}
