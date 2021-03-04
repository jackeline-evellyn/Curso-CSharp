using System;
using _122.Exercicio_2__StringBuilder.Entities;

namespace _122.Exercicio_2__StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Hava a nice trip!");
            Comment comment2 = new Comment("Wow that's awesome");
            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            post1.AddComent(comment1);
            post1.AddComent(comment2);

            Comment comment3 = new Comment("Good night!");
            Comment comment4 = new Comment("May the force be with you");
            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );
            post2.AddComent(comment3);
            post2.AddComent(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        
        }
    }
}
