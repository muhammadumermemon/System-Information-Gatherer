using System;
using System.Management;

class SystemInformationGatherer
{
    static void Main(string[] args)
    {
        // Operating System (OS) information
        Console.WriteLine("Operating System:");
        Console.WriteLine($"  Name: {Environment.OSVersion.VersionString}");
        Console.WriteLine($"  Architecture: {Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit"}");

        // Central Processing Unit (CPU) information
        Console.WriteLine("\nCentral Processing Unit (CPU):");
        Console.WriteLine($"  Number of Cores: {Environment.ProcessorCount}");
        Console.WriteLine($"  Processor Identifier: {Environment.ProcessorIdentifier}");

        // Random Access Memory (RAM) information
        Console.WriteLine("\nRandom Access Memory (RAM):");
        Console.WriteLine($"  Total Memory: {new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024 * 1024)} GB");

        // Disk Drive information
        Console.WriteLine("\nDisk Drive:");
        Console.WriteLine($"  Total Disk Space: {new Microsoft.VisualBasic.Devices.ComputerInfo().TotalDiskSpace / (1024 * 1024 * 1024)} GB");
        Console.WriteLine($"  Free Disk Space: {new Microsoft.VisualBasic.Devices.ComputerInfo().AvailableDiskSpace / (1024 * 1024 * 1024)} GB");

        // Network Adapter information
        Console.WriteLine("\nNetwork Adapter:");
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
        foreach (ManagementObject adapter in searcher.Get())
        {
            Console.WriteLine($"  Adapter Name: {adapter["Name"]}");
            Console.WriteLine($"  Adapter Description: {adapter["Description"]}");
        }
    }
}
```
