using System;
namespace uppgift1
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur gammal du är ?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 16)
            {
                Console.WriteLine("Du är för ung");
            }
            else if (ålder > 19)
            {
                Console.WriteLine("Du är för gammal");
            }
            else
            {
                Console.WriteLine("Du får delta i tävling");
            }
        }
    }
}
