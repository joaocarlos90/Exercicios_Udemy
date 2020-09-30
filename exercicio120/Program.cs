using System;
using exercicio120.Entities;

namespace exercicio120
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("wow that´s awesome");
            Post p1 = new Post(
                DateTime.Now,
                "Traveling to new Zealand",
                "I´m going to visit this wonderful coun",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("may the force be with you");
            Post p2 = new Post(
                DateTime.Now,
                "good night guys",
                "see you tomorrow",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
