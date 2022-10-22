namespace SimpleSoftwareProtection.Core.Interfaces.Brokers.CpuBroker
{
    public interface ICpuBroker
    {
        string GetCpuId();

        ValueTask<string> GetCpuIdAsync();
    }
}
