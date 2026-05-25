using TradingSeller.Domain.Entities;

namespace TradingSeller.Domain.Services;

public interface IExitConditionService
{
    string? CheckExitConditions(Trade trade, decimal currentPrice);
}
