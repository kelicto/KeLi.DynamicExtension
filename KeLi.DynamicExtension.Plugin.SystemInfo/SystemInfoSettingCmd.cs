using System;

using KeLi.DynamicExtension.Tool;

namespace KeLi.DynamicExtension.Plugin.SystemInfo
{
    public class SystemInfoSettingCmd : BaseCommand
    {
        public override void Start()
        {
            Console.WriteLine("Geting System Information...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing...");
        }
    }
}
