namespace OpenDax_Core.Interfaces
{
    public interface IMarket
    {
        string FullName { get; }

        string QuoteCurrency { get; }

        string BaseCurrency { get; }

        bool IsEnabled { get; }
    }
}
