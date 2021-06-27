using System;
using System.IO;
using System.Linq;
using System.Reflection;

using KeLi.DynamicExtension.DB;
using KeLi.DynamicExtension.Tool;

namespace KeLi.DynamicExtension.App
{
    internal class Program
    {
        private static void Main()
        {
            var documentSet = new DocumentSet();
            var currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var currentDirectoryInfo = new DirectoryInfo(currentDir);
            var dllFileInfos = currentDirectoryInfo.GetFiles("*.dll", SearchOption.AllDirectories);

            foreach (var dllFileInfo in dllFileInfos)
            {
                var assembly = Assembly.LoadFrom(dllFileInfo.FullName);
                var types = assembly.GetTypes();
                var targetTypes = types.Where(w => typeof(IExternalCommand).IsAssignableFrom(w)).ToList();

                foreach (var targetType in targetTypes)
                {
                    if (targetType.IsAbstract)
                        continue;

                    var obj = Activator.CreateInstance(targetType, true) as IExternalCommand;

                    obj?.Execute(documentSet);
                }
            }

            Console.ReadKey();
        }
    }
}
