using System;
using System.Globalization;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact("1997-05-24", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact("24/05/1997 14:05:20", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(date);
            Console.WriteLine(date2);

        }
    }
}
