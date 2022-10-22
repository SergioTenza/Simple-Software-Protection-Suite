namespace SimpleSoftwareProtection.Core.Interfaces.Brokers.HddBroker
{
    public interface IHddBroker
    {
        string GetHddId();

        ValueTask<string> GetHddIdAsync();
    }
}
