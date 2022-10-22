namespace SimpleSoftwareProtection.Core.Interfaces
{
    public interface IWindowsHardwareInfo
    {
        void CollectData();
        List<string> Cpus { get; }
        List<string> Hdds { get;}
        List<string> Bios { get;}
    }
}
