namespace OpenDax_Core.Interfaces
{
    public interface IMarket
    {
        string FullName { get; }

        string QuoteCurrency { get; }

        string BaseCurrency { get; }

        bool Enabled { get; }
    }

    public interface ICurrency
    {
        string LogoURL { get; }

        string Name { get; }

        string Id { get; }
    }
}
