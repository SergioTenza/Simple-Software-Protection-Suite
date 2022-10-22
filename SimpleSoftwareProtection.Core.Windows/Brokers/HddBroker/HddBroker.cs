using SimpleSoftwareProtection.Core.Interfaces.Brokers.HddBroker;
using System.Management;

namespace SimpleSoftwareProtection.Core.Windows.Brokers.HddBroker
{
    internal sealed class HddBroker : IHddBroker
    {
        public string GetHddId()
        {
            var response = String.Empty;
            ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");            
            if (hdd is not null)
            {
                var cpuId = hdd.Get().OfType<ManagementObject>().ToList().First()["SerialNumber"].ToString();
                response = String.IsNullOrWhiteSpace(cpuId) ? "0123456789" : cpuId;
            }
            return response;

        }

        public ValueTask<string> GetHddIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
