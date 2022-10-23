using System;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSoftwareProtection.Core.Decryption
{
    public sealed class ValidateKey
    {
        private readonly string PRIVATE_KEY;

        public ValidateKey()
        {
            PRIVATE_KEY =  Environment.GetEnvironmentVariable("SSP_SECRET") 
                ?? throw new ArgumentNullException("The environemt variable SSP_SECRET Must be set on system.");            
        }

        public bool CheckEncryptedKey(string storedKey, string cpuId, string hddId, string biosId)
        {
            var generatedKey = $"{cpuId}{hddId}{biosId}{PRIVATE_KEY}";
            byte[] bytes = Encoding.UTF8.GetBytes(generatedKey);
            byte[] hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashedBytes) == storedKey;
        }

        public ValueTask<bool> GetEncryptedKeyAsync(string storedKey, string cpuId, string hddId, string biosId)
        {
            var generatedKey = $"{cpuId}{hddId}{biosId}{PRIVATE_KEY}";
            byte[] bytes = Encoding.UTF8.GetBytes(generatedKey);
            byte[] hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return new ValueTask<bool>(Convert.ToBase64String(hashedBytes) == storedKey);
        }
    }
}
