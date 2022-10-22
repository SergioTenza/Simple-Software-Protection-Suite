using SimpleSoftwareProtection.Core.Interfaces.Brokers.BiosBroker;
using System.Management;

namespace SimpleSoftwareProtection.Core.Windows.Brokers.BiosBroker
{
    internal sealed class BiosBroker : IBiosBroker
    {
        public string GetBiosId()
        {
            var response = String.Empty;
            ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            if (bios is not null)
            {
                var cpuId = bios.Get().OfType<ManagementObject>().ToList().First()["Version"].ToString();
                response = String.IsNullOrWhiteSpace(cpuId) ? "0123456789" : cpuId;
            }
            return response;
        }

        public ValueTask<string> GetBiosIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
