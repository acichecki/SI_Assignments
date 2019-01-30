using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utf7
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding u7 = Encoding.UTF7;

            string path = @"C:\Users\adam\Desktop\dotNet\SI_Assignments\";

            string gitIgnore = File.ReadAllText(path + ".gitignore");

            Console.WriteLine(gitIgnore);

            byte[] bytes = u7.GetBytes(gitIgnore);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "gitignore_utf7.txt")))
            {
                foreach (var line in bytes)
                    outputFile.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
