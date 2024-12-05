using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C# - проекты\HomeWork8\bin\Debug\RandomNumbers.txt";

            Random random = new Random();

            FileInfo fileInfo = new FileInfo(path);

            using (StreamWriter sx = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sx.WriteLine(random.Next(-50, 50));
                }
            }

            int[] array = new int[10];
            int number = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for(int i = 0;i < array.Length; i++)
                {
                    array[i] = int.Parse(sr.ReadLine());
                    number = array[i] + number;
                }
            }

            Console.WriteLine("Сумма всех чисел = {0}", number);

            Console.ReadKey();
        }
    }
}
