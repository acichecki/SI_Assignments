using System;
using System.IO;
using System.Security.Permissions;

namespace FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.ReadKey();
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private static void Run()
        {
            string[] args = System.Environment.GetCommandLineArgs();

            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Watcher.exe (directory)");
                return;
            }

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = args[1];
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName |
                                   NotifyFilters.DirectoryName;
            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;

        }

        private static void OnRenamed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File renamed to {0}", e.FullPath);
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }
    }
}
