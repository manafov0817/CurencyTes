using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurrencyConverter.Api.Models.Auth
{
    public record LoginRequest
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
