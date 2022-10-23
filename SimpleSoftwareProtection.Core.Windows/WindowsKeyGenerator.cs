using SimpleSoftwareProtection.Core.Interfaces;
using System.Text;

namespace SimpleSoftwareProtection.Core.Windows
{
    public sealed class WindowsKeyGenerator : IWindowsKeyGenerator
    {
        private readonly string _privateKey;
        private readonly string _cpuId;
        private readonly string _hddId;
        private readonly string _biosId;

        public WindowsKeyGenerator(string privateKey, string cpuId, string hddId, string biosId)
        {
            this._privateKey = privateKey;
            this._cpuId = cpuId;
            this._hddId = hddId;
            this._biosId = biosId;
        }

        public string ReturnKey()
        {
            var generatedKey = $"{_cpuId}{_hddId}{_biosId}{_privateKey}";
            byte[] bytes = Encoding.UTF8.GetBytes(generatedKey);
            byte[] hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashedBytes);
        }

        public ValueTask<string> ReturnKeyAsync()
        {
            var generatedKey = $"{_cpuId}{_hddId}{_biosId}{_privateKey}";
            byte[] bytes = Encoding.UTF8.GetBytes(generatedKey);
            byte[] hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return new ValueTask<string>(Convert.ToBase64String(hashedBytes));
        }
    }
}
