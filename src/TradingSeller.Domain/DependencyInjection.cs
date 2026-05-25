using Microsoft.Extensions.DependencyInjection;
using TradingSeller.Domain.Services;

namespace TradingSeller.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        services.AddSingleton<IStressLevelService, StressLevelService>();
        services.AddTransient<IPositionSizingService, PositionSizingService>();
        services.AddTransient<ITradeValidationService, TradeValidationService>();
        services.AddTransient<IExitConditionService, ExitConditionService>();
        services.AddTransient<ICapitalCalculator, CapitalCalculator>();
        return services;
    }
}
