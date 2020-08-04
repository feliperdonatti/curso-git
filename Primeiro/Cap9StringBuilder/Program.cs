using Cap9StringBuilder.Entities;
using System;

namespace Cap9StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Comment c1 = new Comment("have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");

            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zeland",
                    "I'm going to visit this wonderful country",
                    10
                );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);

        }
    }
}
