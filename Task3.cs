using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    //Напишите утилиту читающую тестовый файл и выводящую на экран строки содержащие искомое слово.
    internal class Task3
    {
        public static void FindWord(string path, string word)
        {
            using(StreamReader sr = new StreamReader(path))
            {                
                while (!sr.EndOfStream)
                {
                    var tempStr = sr.ReadLine();
                    if (tempStr.Contains(word))
                    {
                        Console.WriteLine(tempStr);
                    }
                }
            }
        }
    }
}
