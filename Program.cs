using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\C# - проекты\\HomeWork8";

            string[] directories =  Directory.GetDirectories(path);

            string[] subDirectories = { };

            foreach (string directory in directories)
            {
                Console.WriteLine(directory + ": ");

                subDirectories = Directory.GetDirectories(directory);
                Console.WriteLine();
                foreach(string pathSubDirectories in subDirectories)
                {
                    Console.WriteLine(pathSubDirectories);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

           
        }
    }
}
