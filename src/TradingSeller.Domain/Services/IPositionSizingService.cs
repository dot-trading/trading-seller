namespace TradingSeller.Domain.Services;

public interface IPositionSizingService
{
    decimal CalculateQuantity(decimal capital, decimal entryPrice, decimal riskPercent);
}
