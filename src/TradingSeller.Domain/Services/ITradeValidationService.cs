using TradingSeller.Domain.Entities;

namespace TradingSeller.Domain.Services;

public interface ITradeValidationService
{
    (bool IsValid, string? Error) ValidateTrade(Trade trade);
}
