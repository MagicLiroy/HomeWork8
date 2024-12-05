using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task3
{
    internal class Program
    {
        static int CountWords(string str)
        {
            if (string.IsNullOrEmpty(str)) 
            { 
                return 0; 
            }
            string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?' }, 
            StringSplitOptions.RemoveEmptyEntries); 
            return words.Length;
        }

        static int CountSymbols(string str)
        {
            int counter = 0;

            foreach (char s in str)
            {
                counter++;
            }
            return counter;
        }

        static int CountRows(string str)
        {
            string[] textArray = str.Split('\n');
            int counter = textArray.Length;

            return counter;
        }

        static void Main(string[] args)
        {
            string path = "D:\\C# - проекты\\HomeWork8\\bin\\Debug\\ForWork.txt";

            int words = 0;
            int symbols = 0;
            int rows = 0;

            string[] array = new string[100];

            using (StreamReader sr = new StreamReader(path))
            {
                //for (int i = 0; i < array.Length; i++)
                //{
                //    rows++;
                //}
                string text = sr.ReadToEnd();

                string[] textArray = text.Split('\n');
                rows = CountRows(text);

                words = CountWords(text);

                symbols = CountSymbols(text);
            }

            Console.WriteLine($"Количество строк: {rows}");
            Console.WriteLine($"Количество символов: {symbols}");
            Console.WriteLine($"Количество слов: {words}");

            Console.ReadKey();
        }
    }
}
