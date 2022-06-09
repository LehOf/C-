using System;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 01, 28, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}