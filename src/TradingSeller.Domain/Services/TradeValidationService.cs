using TradingSeller.Domain.Entities;

namespace TradingSeller.Domain.Services;

public class TradeValidationService : ITradeValidationService
{
    public (bool IsValid, string? Error) ValidateTrade(Trade trade)
    {
        if (string.IsNullOrWhiteSpace(trade.Symbol))
            return (false, "Symbol is required");
        if (trade.Price <= 0)
            return (false, "Price must be greater than zero");
        if (trade.Quantity <= 0)
            return (false, "Quantity must be greater than zero");
        return (true, null);
    }
}
