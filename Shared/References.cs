namespace Stryx.OS;

public static class References
{
    public static string Application_Name { get; } = "StryxOS";
    public static Version Application_Version { get; } = Runtime.Application_Shared_Assembly_Name != null && 
                                                         Runtime.Application_Shared_Assembly_Name.Version != null ? 
                                                         Runtime.Application_Shared_Assembly_Name.Version : new Version();
    public static string Application_Version_Format_String { get; } = Runtime.Application_Shared_Assembly_Name != null ? 
                                                                      $"{Application_Version.Major}.{Application_Version.Minor}.{Application_Version.Build}.{Application_Version.Revision}" : "Unknown";
    public static string[] Application_Authors { get; } = new string[] { "Connor 'Stryxus' Shearer" };
    public static string Application_Copyright { get; } = $"Copyright © {Application_Authors[0]} {DateTime.UtcNow.Year}";
}
