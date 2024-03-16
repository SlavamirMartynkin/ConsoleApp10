using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    /*Напишите утилиту рекурсивного поиска файлов в заданном каталоге и подкаталогах
     * Пример запуска: utility.exe c:\t file1.txt*/
    internal class Task2
    {        
        public static void FindFiles(string path, string fileName, List<string> list)
        {
            list.AddRange(Directory.GetFiles(path, fileName)); // в одну строку
            /*
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (Path.GetFileName(file) == fileName)
                {
                    list.Add(file);
                }                
            }
            */
            foreach (var dir in Directory.GetDirectories(path))
            {
                FindFiles(dir, fileName, list);
            }
        }
    }
}
