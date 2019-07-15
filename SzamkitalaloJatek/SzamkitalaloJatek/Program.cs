using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamkitalaloJatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rNumber = new Random();
            int rNum = rNumber.Next(1, 101);
            int guess;
            int rounds = 0;
            int rComp = rNumber.Next(1, 101);
            bool end = false;
            do
            {
                rounds++;
                Console.Write($"{rounds}. Round - Computer: {rComp} | Player: ");
                guess = int.Parse(Console.ReadLine());

                if (guess == rNum)
                {
                    Console.Write("\nCongratualtion! You won!");
                    end = true;
                    break;
                }
                else if (guess < rNum)
                {
                    Console.WriteLine("Your number was too low\n");
                }
                else if (guess > rNum)
                {
                    Console.WriteLine("Your number was to high\n");
                }

                if (rComp == rNum)
                {
                    Console.Write("\nCumputer won! Maybe next time.");
                    end = true;
                    break;
                }
                else
                {
                    if (rComp < rNum)
                    {
                        rComp = rNumber.Next(rComp + 1, rNum + 1);
                    }
                    else if (rComp > rNum)
                    {
                        rComp = rNumber.Next(rNum, rComp - 1);
                    }
                }   
            } while (end == false);
            Console.WriteLine($"\nThe number was {rNum}");
            Console.ReadKey();
        }
    }
}
