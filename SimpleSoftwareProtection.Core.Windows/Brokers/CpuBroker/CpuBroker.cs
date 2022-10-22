using SimpleSoftwareProtection.Core.Interfaces.Brokers.CpuBroker;
using System.Management;

namespace SimpleSoftwareProtection.Core.Windows.Brokers.CpuBroker
{
    internal sealed class CpuBroker : ICpuBroker
    {
        public string GetCpuId()
        {
            var response = String.Empty;
            ManagementObjectSearcher cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");            
            if (cpu is not null)
            {
                var cpuId = cpu.Get().OfType<ManagementObject>().ToList().First()["ProcessorId"].ToString();
                response = String.IsNullOrWhiteSpace(cpuId) ? "0123456789" : cpuId;
            }
            return response;

        }

        public ValueTask<string> GetCpuIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
