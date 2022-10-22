using SimpleSoftwareProtection.Core.Interfaces;
using SimpleSoftwareProtection.Core.Interfaces.Brokers.BiosBroker;
using SimpleSoftwareProtection.Core.Interfaces.Brokers.CpuBroker;
using SimpleSoftwareProtection.Core.Interfaces.Brokers.HddBroker;
using SimpleSoftwareProtection.Core.Windows.Brokers.BiosBroker;
using SimpleSoftwareProtection.Core.Windows.Brokers.CpuBroker;
using SimpleSoftwareProtection.Core.Windows.Brokers.HddBroker;
using System.Text;

namespace SimpleSoftwareProtection.Core.Windows
{
    public sealed class WindowsKeyGenerator : IWindowsKeyGenerator
    {
        private readonly string _privateKey;
        private readonly ICpuBroker _cpuBroker;
        private readonly IHddBroker _hddBroker;
        private readonly IBiosBroker _biosBroker;

        public WindowsKeyGenerator(string privateKey)
        {
            this._privateKey = privateKey;
            _cpuBroker = new CpuBroker();
            _hddBroker = new HddBroker();
            _biosBroker = new BiosBroker();
        }

        public string ReturnKey()
        {
            var cpu = this._cpuBroker.GetCpuId();
            var hdd = this._hddBroker.GetHddId();
            var bios = this._biosBroker.GetBiosId();
            var generatedKey = $"{cpu}{hdd}{bios}{_privateKey}";
            byte[] bytes = Encoding.UTF8.GetBytes(generatedKey);
            byte[] hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashedBytes);
        }

        public ValueTask<string> ReturnKeyAsync()
        {
            throw new NotImplementedException();
        }
    }
}
