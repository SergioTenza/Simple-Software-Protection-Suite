namespace SimpleSoftwareProtection.Core.Interfaces.Brokers.BiosBroker
{
    public interface IBiosBroker
    {
        string GetBiosId();

        ValueTask<string> GetBiosIdAsync();
    }
}
