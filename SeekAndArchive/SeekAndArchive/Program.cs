using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            string filePath = args[1];

            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

            Console.WriteLine(fileName);

            foreach (var file in directoryInfo.GetFiles())
            {
                if (file.Name == fileName)
                {
                    Console.WriteLine(file.FullName);
                }
            }

            foreach (var directory in directoryInfo.GetDirectories())
            {
                foreach (var file in directory.GetFiles())
                {
                    if (file.Name == fileName)
                    {
                        Console.WriteLine(file.FullName);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
