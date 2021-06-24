using System.IO;
using System.Reflection;

namespace KeLi.DynamicExtension.App
{
    internal class Program
    {
        private static void Main()
        {
            var currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var currentDirectoryInfo = new DirectoryInfo(currentDir);
            var dllFileInfos = currentDirectoryInfo.GetFiles("*.dll", SearchOption.AllDirectories);

            foreach (var dllFileInfo in dllFileInfos)
            {
                var assembly = Assembly.LoadFrom(dllFileInfo.FullName);
                var types = assembly.GetTypes();

                foreach (var type in types)
                {

                }
            }
        }
    }
}
