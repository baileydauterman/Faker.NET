using Faker.NET.Common.System;

namespace Faker.NET.Interfaces.Modules;

public interface IFakerSystem
{
    public string CommonFileExt();
    public string CommonFileName(string extension = "");
    public string CommonFileType();
    public string Cron(bool includeNonStandard = false, bool includeYear = false);
    public string DirectoryPath();
    public string FileExt(string mimeType = "");
    public string FileName(uint min = uint.MinValue, uint max = 3);
    public string FilePath();
    public string FileType();
    public string MimeType();
    public string NetworkInterface(NetworkInterfaceType? interfaceType = null, NetworkInterfaceSchema? interfaceSchema = null);
    public string Semver();
}
