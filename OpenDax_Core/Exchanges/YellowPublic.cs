using Newtonsoft.Json;
using OpenDax_Core.Interfaces;
using OpenDax_Core.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDax_Core.Exchanges
{
    public class YellowPublic : IPublicExchange
    {
        #region private fields
        private RestClient _restClient = new  RestClient("https://www.yellow.com/api/v2/peatio/public/");

        private List<Market> _markets = new List<Market>();
        private List<Currency> _currencies = new List<Currency>();

        #endregion

        public IList<IMarket> Markets
        {
            get => (IList<IMarket>)_markets;
        }

        public IList<ICurrency> Currencies
        {
            get => (IList<ICurrency>)_currencies;
        }

        public event OnConnectedHandler OnConnected;

        public async Task InitAsync()
        {
            try
            {
                // get markets
                var request = new RestRequest("markets", Method.GET);

                var execute = await _restClient.ExecuteGetAsync(request);
                 _markets = JsonConvert.DeserializeObject<List<Market>>(execute.Content);

                // get currencies
                request = new RestRequest("currencies", Method.GET);

                execute = await _restClient.ExecuteGetAsync(request);
                _currencies = JsonConvert.DeserializeObject<List<Currency>>(execute.Content);

                OnConnected?.Invoke();
            }
            catch
            {
                //TODO : handle exception
            }
        }
    }
}
