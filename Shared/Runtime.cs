using System.Reflection;

namespace Stryx.OS;

public static class Runtime
{
    public static Assembly Application_Shared_Assembly => typeof(Runtime).Assembly;
    public static AssemblyName Application_Shared_Assembly_Name { get; } = typeof(Runtime).Assembly.GetName();
}
