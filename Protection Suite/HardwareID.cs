using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management;
using System.Security.Policy;

namespace Funphotos_Protection_Suite
{
    class HardwareID
    {
        public static string GET_HARDWAREID => ReturnHardwareID().Result;
        public static string GET_CPUID;
        public static string GET_HDDSIGNATURE;
        public static string GET_BIOSVERSION;
        private static async Task<string > ReturnHardwareID()
        {
            byte[] bytes;
            byte[] hashedBytes;            
            StringBuilder sb = new StringBuilder();

            Task task = Task.Run(() =>
            {
                ManagementObjectSearcher cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                ManagementObjectCollection cpu_collection = cpu.Get();
                foreach (ManagementObject obj in cpu_collection)
                {
                    sb.Append(obj["ProcessorId"].ToString().Substring(0,10));
                    GET_CPUID = obj["ProcessorId"].ToString();
                    break;
                }

                ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                ManagementObjectCollection hdd_collection = hdd.Get();
                foreach (ManagementObject obj in hdd_collection)
                {
                    sb.Append(obj["SerialNumber"].ToString().Substring(0, 10));
                    GET_HDDSIGNATURE = obj["SerialNumber"].ToString();
                    break;
                }

                ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
                ManagementObjectCollection bios_collection = bios.Get();
                foreach (ManagementObject obj in bios_collection)
                {
                    sb.Append(obj["Version"].ToString().Substring(0, 10));
                    GET_BIOSVERSION = obj["Version"].ToString();
                    break;
                }
            });
            Task.WaitAll(task);            

            bytes = System.Text.Encoding.UTF8.GetBytes(sb.ToString());
            hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
            return await Task.FromResult(Convert.ToBase64String(hashedBytes).Substring(25));
        }
    }
}
