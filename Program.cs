namespace ConsoleApp10
{
    internal class Program
    {

        static void Main(string[] args)
        {            
            List<string> list = new List<string>();

            HomeWork.FindFiles("C:\\Users\\SlavaMar\\Desktop", "*.txt", list);

            foreach (string file in list)
            {
                if (HomeWork.FindWord(file, "text") == true)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
