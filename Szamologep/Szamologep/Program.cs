using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            char z;

            if (args.Length == 0)
            {
                Console.WriteLine("Adjon meg egy számot: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Adjon meg még egy számot: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("Adjon meg egy műveletet(+, -, /, *): ");
                z = Convert.ToChar(Console.ReadLine());
            }
            else
            {
                if (args.Length != 3)
                {
                    Console.WriteLine("Nem megfelelő paraméterszám!");
                    return;
                }
                else
                {
                    x = int.Parse(args[0]);
                    y = int.Parse(args[1]);
                    z = Convert.ToChar(args[2]);
                    Console.WriteLine(args[0] + " " + args[2] + " " + args[1]);
                }
            }

            int result = 0;

            switch (z)
            {
                case '-':
                    result = x - y;
                    break;
                case '+':
                    result = x + y;
                    break;
                case '/':
                    result = x / y;
                    break;
                case '*':
                    result = x * y;
                    break;
            }
            Console.WriteLine($"Eredmény: {result}");

            Console.ReadKey();
        }
    }
}
