using System;
using Course.Entities;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            Comment c1 = new Comment("Have nic trip! ");
            Comment c2 = new Comment("WOW, that's awesome! ");

            Postt p1 = new Postt(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

            p1.AddComments(c1);
            p1.AddComments(c2);

            Comment c3 = new Comment("Good night ");
            Comment c4 = new Comment("May the Force be with you ");

            Postt p2 = new Postt(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);

            p2.AddComments(c3);
            p2.AddComments(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            

        }
    }
}
