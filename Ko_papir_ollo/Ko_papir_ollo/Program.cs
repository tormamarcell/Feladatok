using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ko_papir_ollo
{
    class Program
    {
        static void Main(string[] args)
        {
            int jatekosP = 0;
            int gepP = 0;
            Random r = new Random();
            string resultG = "";
            string resultP = "";
            bool l = true;
            do
            {
                Console.WriteLine("Játékos választása(k/p/o): ");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        resultP = "kő";
                        break;
                    case 'p':
                        resultP = "papír";
                        break;
                    case 'o':
                        resultP = "olló";
                        break;
                }
                switch(r.Next(0, 3))
                {
                    case 0:
                        resultG = "kő";
                    break;
                    case 1:
                        resultG = "papír";
                    break;
                    case 2:
                        resultG = "olló";
                    break;
                }
                Console.WriteLine($"A játékos választása: {resultP}");
                Console.WriteLine($"A gép választása: {resultG}");

                if ((resultP == "kő" && resultG == "olló") || (resultP == "papír" && resultG == "kő") || (resultP == "olló" && resultG == "papír"))
                {
                    Console.WriteLine($"Nyertél!\nJátékos pontszáma: {++jatekosP}\nGép pontszáma: {gepP}");
                }
                else
                {
                    Console.WriteLine($"A gép nyert!\nJátékos pontszáma: {jatekosP}\nGép pontszáma: {++gepP}");
                }
                Console.WriteLine("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                    l = false;
            } while (l);
        }
    }
}
