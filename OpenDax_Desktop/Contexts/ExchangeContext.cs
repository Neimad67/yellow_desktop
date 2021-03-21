using OpenDax_Core.Exchanges;

namespace OpenDax_Desktop.Contexts
{
    public static class ExchangeContext
    {
        private static YellowPublic _publicInstance = new YellowPublic();

        public static YellowPublic PublicInstace 
        {
            get => _publicInstance;
        }
    }
}
