using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shall we play a game?");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try and guess it!");
            Console.WriteLine();
            var guess = 0;
            while(guess != 37)
            {
                Console.Write("What's your guess? ");
                int.TryParse(Console.ReadLine(), out guess);
                if (guess != 37)
                {
                    if (guess < 37)
                    {
                        Console.WriteLine("Higher...");
                    }
                    else
                    {
                        Console.WriteLine("Lower...");
                    }
                }
            }
            Console.WriteLine("You win! The correct number was 37");
            Console.ReadKey();
        }
    }
}
