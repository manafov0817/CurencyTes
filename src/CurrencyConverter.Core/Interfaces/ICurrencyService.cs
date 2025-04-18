using CurrencyConverter.Core.Models.Currency;

namespace CurrencyConverter.Core.Interfaces
{
    public interface ICurrencyService
    {
        Task<ExchangeRateResponse> GetLatestRatesAsync(string baseCurrency);
        Task<CurrencyConversionResponse> ConvertCurrencyAsync(CurrencyConversionRequest request);
        Task<PaginatedResponse<HistoricalRate>> GetHistoricalRatesAsync(HistoricalRatesRequest request);
    }
}
