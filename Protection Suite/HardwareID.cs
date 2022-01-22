using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management;
using System.Security.Policy;
using System.Collections;

namespace Funphotos_Protection_Suite
{
    class HardwareID
    {
        public static string PRIVATE_KEY = "";
        public static string GET_CPUID;
        public static string GET_HDDSIGNATURE;
        public static string GET_BIOSVERSION;

        public static List<string> cpus = new List<string>();
        public static List<string> hdds = new List<string>();
        public static List<string> bioses = new List<string>();            
        
        public static string ReturnKey()
        {
            byte[] bytes;
            byte[] hashedBytes;
            StringBuilder sb = new StringBuilder();

            string _key="";
            bool isCpu = String.IsNullOrEmpty(GET_CPUID);
            bool isHdd = String.IsNullOrEmpty(GET_HDDSIGNATURE);
            bool isBios = String.IsNullOrEmpty(GET_BIOSVERSION);
            bool isPKey = String.IsNullOrEmpty(PRIVATE_KEY);
            if (!isCpu && !isHdd && !isBios && !isPKey)
            {
                sb.Append(GET_CPUID);
                sb.Append(GET_HDDSIGNATURE);
                sb.Append(GET_BIOSVERSION);
                sb.Append(PRIVATE_KEY);
                bytes = Encoding.UTF8.GetBytes(sb.ToString());
                hashedBytes = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes);
                _key = Convert.ToBase64String(hashedBytes).Substring(25);
            }
            else
            {
                _key = "Elija primero opciones validas";
            }
            
            return _key;
        }
        
        public static void CollectData()
        {
            cpus.Clear();
            hdds.Clear();
            bioses.Clear();

            ManagementObjectSearcher cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection cpu_collection = cpu.Get();
            foreach (ManagementObject obj in cpu_collection)
            {                
                GET_CPUID = obj["ProcessorId"].ToString();
                cpus.Add(GET_CPUID);                
            }

            ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection hdd_collection = hdd.Get();
            foreach (ManagementObject obj in hdd_collection)
            {
                GET_HDDSIGNATURE = obj["SerialNumber"].ToString();
                hdds.Add(GET_HDDSIGNATURE);
            }

            ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            ManagementObjectCollection bios_collection = bios.Get();
            foreach (ManagementObject obj in bios_collection)
            {
                GET_BIOSVERSION = obj["Version"].ToString();
                bioses.Add(GET_BIOSVERSION);
            }
        }
    }
}
