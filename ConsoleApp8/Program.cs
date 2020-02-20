using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time1 = new TimeSpan(0, 1, 30);
            TimeSpan time2 = new TimeSpan();
            TimeSpan time3 = new TimeSpan(900000000L);
            TimeSpan time4 = new TimeSpan(2, 11, 21);
            TimeSpan time5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan time6 = new TimeSpan(1, 2, 11, 21, 321);
            TimeSpan time7 = TimeSpan.FromDays(1.5);
            TimeSpan time8 = TimeSpan.FromHours(1.5);
            TimeSpan time9 = TimeSpan.FromMinutes(1.5);
            TimeSpan time10 = TimeSpan.FromSeconds(1.5);
            TimeSpan time11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan time12 = TimeSpan.FromTicks(900000000L);





            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.WriteLine(time4);
            Console.WriteLine(time5);
            Console.WriteLine(time6);
            Console.WriteLine(time7);
            Console.WriteLine(time8);
            Console.WriteLine(time9);
            Console.WriteLine(time10);
            Console.WriteLine(time11);
            Console.WriteLine(time12);
        }
    }
}
