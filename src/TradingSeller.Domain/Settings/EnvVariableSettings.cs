namespace TradingSeller.Domain.Settings;

public class EnvVariableSettings
{
    public string QuoteAsset => Environment.GetEnvironmentVariable("QUOTE_ASSET")?.ToUpper() ?? "USDC";
    public string RedisConnectionString => Environment.GetEnvironmentVariable("REDIS_CONNECTION_STRING") ?? "localhost:6379";
    public string PersistenceServiceUrl => Environment.GetEnvironmentVariable("PERSISTENCE_SERVICE_URL") ?? "http://trading-persistence-api";
    public string ThirdPartyProviderUrl => Environment.GetEnvironmentVariable("THIRD_PARTY_PROVIDER_URL") ?? "http://third-party-provider";
    public string OllamaUrl => Environment.GetEnvironmentVariable("OLLAMA_URL") ?? "http://ollama-eur:11434";
    public bool PaperMode => bool.TryParse(Environment.GetEnvironmentVariable("PAPER_MODE"), out var mode) && mode;
}
