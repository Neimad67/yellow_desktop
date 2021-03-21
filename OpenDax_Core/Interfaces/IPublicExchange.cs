using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDax_Core.Interfaces
{
    public interface IPublicExchange
    {
        event OnConnectedHandler OnConnected;

        Task InitAsync();

        IList<IMarket> Markets { get; }
    }

    public delegate void OnConnectedHandler();
}
