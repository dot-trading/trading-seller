namespace TradingSeller.Domain.Constants;

public static class Trades
{
    private static readonly Dictionary<string, string[]> SpotMapping = new()
    {
        ["BTC"] = ["AAVE", "ADA", "ADX", "ALGO", "APT", "AR", "ARB", "ATOM", "AVAX", "AXL",
            "BCH", "BNB", "CAKE", "CHZ", "CRV", "CTK", "CTSI", "DOGE", "DOT", "DUSK",
            "EGLD", "ETC", "ETH", "FET", "FIL", "GLM", "HBAR", "ICP", "INJ", "IOTA",
            "JST", "KAVA", "KNC", "LINK", "LPT", "LTC", "NEAR", "NEXO", "ONG", "ONT",
            "PENDLE", "POL", "QNT", "RENDER", "RUNE", "S", "SAGA", "SEI", "SKY", "SOL",
            "STEEM", "STX", "SUI", "SUPER", "TAO", "THETA", "TRX", "UNI", "WLD", "XLM",
            "XRP", "XTZ"],
        ["USDC"] = ["AAVE", "ADA", "ALGO", "APT", "AR", "ARB", "ATOM", "AVAX", "BCH", "BNB",
            "CAKE", "CHZ", "CRV", "DOGE", "DOT", "EGLD", "ENSO", "ERA", "ETC", "ETH",
            "FET", "FIL", "GUN", "HBAR", "ICP", "INJ", "IOTA", "LINK", "LPT", "LTC",
            "NEAR", "NIGHT", "ONT", "OPEN", "OPN", "PARTI", "PENDLE", "POL", "QNT",
            "RENDER", "RUNE", "S", "SAGA", "SEI", "SIGN", "SKY", "SOL", "STEEM", "STX",
            "SUI", "TAO", "THETA", "TRX", "UNI", "WAL", "WLD", "XLM", "XRP", "XTZ"],
        ["BNB"] = ["ADA", "CAKE", "CTK", "DOT", "ENSO", "ERA", "FET", "GUN", "HBAR", "LTC",
            "NIGHT", "OPEN", "OPN", "PARTI", "POL", "S", "SIGN", "SOL", "SUI", "TRX",
            "WAL", "XRP"],
        ["ETH"] = ["AAVE", "ADA", "APT", "ARB", "AVAX", "BNB", "DOT", "EGLD", "LINK", "LTC",
            "POL", "SOL", "TRX", "UNI", "WBETH", "XLM", "XRP"]
    };

    public static string[] Spots(string asset) => SpotMapping[asset.ToUpper()];
}
