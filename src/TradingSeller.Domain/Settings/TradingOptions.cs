namespace TradingSeller.Domain.Settings;

public class TradingOptions
{
    public const string SectionName = "Trading";

    public string QuoteAsset { get; set; } = "USDC";
    public bool EnableStressLimits { get; set; } = true;
    public decimal MinPositionUsdt { get; set; } = 12.0m;
    public decimal TargetPositionAmount { get; set; } = 20.0m;
    public int FastExitIntervalSeconds { get; set; } = 10;
    public int FastExitStartupDelaySeconds { get; set; } = 5;
    public string OllamaModel { get; set; } = "qwen2.5:3b";
    public string OllamaExitModel { get; set; } = "qwen2.5:3b";
}
