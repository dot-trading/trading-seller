using TradingSeller.Domain.Entities;

namespace TradingSeller.Domain.Services;

public class ExitConditionService : IExitConditionService
{
    public string? CheckExitConditions(Trade trade, decimal currentPrice)
    {
        // Stop-loss check
        if (trade.StopLoss.HasValue && currentPrice <= trade.StopLoss.Value)
            return $"Stop-loss hit (entry: {trade.Price}, SL: {trade.StopLoss}, current: {currentPrice})";

        // Take-profit check
        if (trade.TakeProfit.HasValue && currentPrice >= trade.TakeProfit.Value)
            return $"Take-profit hit (entry: {trade.Price}, TP: {trade.TakeProfit}, current: {currentPrice})";

        // Time-stop: close positions older than 7 days
        var age = DateTime.UtcNow - trade.CreatedAt;
        if (age.TotalDays >= 7)
            return $"Time-stop (position age: {age.TotalDays:F1} days)";

        return null;
    }
}
