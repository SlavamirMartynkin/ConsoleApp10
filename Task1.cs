using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Task1
    {
        public static void CopyFileToFile(string[] args)
        {
            /*Напишите консольную утилиту для копирования файлов 
             * Пример запуска: utility.exe file1.txt file2.txt*/
            if (args.Length < 2)
            {
                Console.WriteLine("Нет параметров запуска.");
            }
            else
            {
                if (!File.Exists(args[0]))
                {
                    using (StreamWriter sw = new StreamWriter(args[0]))
                    {
                        sw.WriteLine("text text text!");
                    }
                }
                using (StreamWriter sw = new StreamWriter(args[1]))
                {
                    using (StreamReader sr = new StreamReader(args[0]))
                    {
                        sw.Write(sr.ReadToEnd());
                    }
                }
            }
        }
    }
}
