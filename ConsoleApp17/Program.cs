using System;
using ConsoleApp17.Entities;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new zeland",
                "I'm going to visit this awesome country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("may the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:45:14"),
                "Good night guys",
                "See youtomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
