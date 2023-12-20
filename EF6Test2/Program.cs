using System;

namespace EF6Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App");
            using (var context = new ApplicationDbContext())
            {

            }
            Console.ReadKey();
        }
    }
}
