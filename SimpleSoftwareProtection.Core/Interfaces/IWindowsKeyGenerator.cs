namespace SimpleSoftwareProtection.Core.Interfaces
{
    public interface IWindowsKeyGenerator
    {
        string ReturnKey();
        ValueTask<string> ReturnKeyAsync();
    }
}
