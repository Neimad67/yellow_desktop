using OpenDax_Desktop.Contexts;
using System.Threading.Tasks;

namespace OpenDax_Desktop.ViewModels
{
    public class SplashScreenVM
    {
        private string _action = "Init";


        public string Action
        {
            get => _action;
            private set => _action = value;
        }

        public async Task InitAsync()
        {
            await ExchangeContext.PublicInstace.InitAsync();
        }
    }
}
