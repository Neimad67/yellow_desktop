using Newtonsoft.Json;
using OpenDax_Core.Interfaces;

namespace OpenDax_Core.Models
{
    public class Market : IMarket
    {
        public string FullName
        {
            get => string.Format("{0}/{1}", BaseCurrency, QuoteCurrency);
        }

        [JsonProperty("quote_unit")]
        public string QuoteCurrency { get; set; }

        [JsonProperty("base_unit")]
        public string BaseCurrency 
        {
            get;set;
        }

        [JsonIgnore]
        public bool Enabled
        {
            get => enabled == "enabled";
        }

        [JsonProperty("enabled")]
        public string enabled { get; set; } = string.Empty;
    }

    public class Currency : ICurrency
    {
        public string LogoURL => throw new System.NotImplementedException();

        public string Name => throw new System.NotImplementedException();

        public string Id => throw new System.NotImplementedException();
    }
}
