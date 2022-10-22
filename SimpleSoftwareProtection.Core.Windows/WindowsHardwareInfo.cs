using SimpleSoftwareProtection.Core.Interfaces;
using System.Management;

namespace SimpleSoftwareProtection.Core.Windows
{
    public sealed class WindowsHardwareInfo : IWindowsHardwareInfo
    {
        public List<string> Cpus
        {
            get => _cpus;
        }
        private List<string> _cpus = new();

        public List<string> Hdds
        {
            get => _hdds;
        }
        private List<string> _hdds = new();

        public List<string> Bios
        {
            get => _bios;
        }
        private List<string> _bios = new();

        public void CollectData()
        {
            _cpus.Clear();
            _hdds.Clear();
            _bios.Clear();

            ManagementObjectSearcher cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection cpu_collection = cpu.Get();
            foreach (ManagementObject obj in cpu_collection)
            {
                var cpuName = obj["ProcessorId"].ToString();
                if (!String.IsNullOrWhiteSpace(cpuName)) _cpus.Add(cpuName);
            }

            ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection hdd_collection = hdd.Get();
            foreach (ManagementObject obj in hdd_collection)
            {
                var hddName = obj["SerialNumber"].ToString();
                if (!String.IsNullOrWhiteSpace(hddName)) _hdds.Add(hddName);
            }

            ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            ManagementObjectCollection bios_collection = bios.Get();
            foreach (ManagementObject obj in bios_collection)
            {
                var biosName = obj["Version"].ToString();
                if (!String.IsNullOrWhiteSpace(biosName)) _bios.Add(biosName);
            }
        }
    }
}
