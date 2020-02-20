using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime t1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime t2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine($"t1: {t1}");
            Console.WriteLine($"t1 kind: {t1.Kind}");
            Console.WriteLine($"t1 to local: {t1.ToLocalTime()}");
            Console.WriteLine($"t1 to utc: {t1.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine($"t2: {t2}");
            Console.WriteLine($"t2 kind: {t2.Kind}");
            Console.WriteLine($"t2 to local: {t2.ToLocalTime()}");
            Console.WriteLine($"t2 to utc: {t2.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine(t2.ToString("yyyy-MM-ddTHH:mmssZ")); // da pau
            Console.WriteLine(t2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mmssZ")); // correto


            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine($"D1: {d1}");
            //Console.WriteLine($"D1 Kind: {d1.Kind}");
            //Console.WriteLine($"D1 to local: {d1.ToLocalTime()}");
            //Console.WriteLine($"D1 to utc: {d1.ToUniversalTime()}");

            //Console.WriteLine();

            //Console.WriteLine($"D2: {d2}");
            //Console.WriteLine($"D2 Kind: {d2.Kind}");
            //Console.WriteLine($"D2 to local: {d2.ToLocalTime()}");
            //Console.WriteLine($"D2 to utc: {d2.ToUniversalTime()}");

            //Console.WriteLine();

            //Console.WriteLine($"D3: {d3}");
            //Console.WriteLine($"D3 Kind: {d3.Kind}");
            //Console.WriteLine($"D3 to local: {d3.ToLocalTime()}");
            //Console.WriteLine($"D3 to utc: {d3.ToUniversalTime()}");

        }
    }
}
