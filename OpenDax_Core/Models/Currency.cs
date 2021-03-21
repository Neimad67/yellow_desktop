using Newtonsoft.Json;
using OpenDax_Core.Interfaces;

namespace OpenDax_Core.Models
{
    public class Currency : ICurrency
    {
        [JsonProperty("icon_url")]
        public string LogoURL { get; set; }

        public string Name { get; set; }

        public string Id { get; set; }
    }
}
