using Newtonsoft.Json;
using OpenDax_Core.Interfaces;

namespace OpenDax_Core.Models
{
    public class Market : IMarket
    {
        public string FullName
        {
            get => string.Format("{0}/{1}", BaseCurrency.ToUpper(), QuoteCurrency.ToUpper());
        }

        [JsonProperty("quote_unit")]
        public string QuoteCurrency { get; set; }

        [JsonProperty("base_unit")]
        public string BaseCurrency 
        {
            get;set;
        }

        public bool IsEnabled
        {
            get => enabled == "enabled";
        }

        [JsonProperty("enabled")]
        public string enabled { get; set; } = string.Empty;
    }
}
