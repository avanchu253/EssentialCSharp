using System.Reflection;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public static class NetCore
    {
        public static string GetNetCoreVersion()
        {
            Assembly assembly = typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly;
            string[] assemblyPath = assembly.Location!.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            int netCoreAppIndex = Array.IndexOf(assemblyPath, "Microsoft.NETCore.App");
            if (netCoreAppIndex > 0 && netCoreAppIndex < assemblyPath.Length - 2)
                return assemblyPath[netCoreAppIndex + 1];
            throw new Exception("Unable to determine .NET Core version.");
        }
    }
}
