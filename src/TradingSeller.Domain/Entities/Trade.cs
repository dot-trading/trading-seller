using TradingSeller.Domain.Enums;

namespace TradingSeller.Domain.Entities;

public class Trade
{
    public int Id { get; set; }
    public string Symbol { get; set; } = null!;
    public TradeSide Side { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public decimal UsdtValue { get; set; }
    public decimal? StopLoss { get; set; }
    public decimal? TakeProfit { get; set; }
    public string? AiSource { get; set; }
    public int? AiScore { get; set; }
    public string? AiReason { get; set; }
    public string? BinanceOrderId { get; set; }
    public TradeStatus Status { get; set; } = TradeStatus.Open;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public decimal? ClosePrice { get; set; }
    public DateTime? CloseAt { get; set; }
    public decimal? PnlUsdt { get; set; }
    public decimal? PnlPct { get; set; }
}
