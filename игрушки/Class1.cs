using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace игрушки
{
    internal class Str
    {
        public static int strelka(int position, int minStrelocka, int maxStrelochka)
        {
            ConsoleKeyInfo knopka;
            do
            {
                
                knopka = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (knopka.Key == ConsoleKey.UpArrow && position != minStrelocka)
                {
                    position--;

                }
                else if (knopka.Key == ConsoleKey.DownArrow && position != maxStrelochka)
                {
                    position++;

                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("пПриятного аппетита! Досвидания");
                    Environment.Exit(0);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

            } while (knopka.Key != ConsoleKey.Enter);
            return position;

        }
        public static int strelk(int position, int minStrelocka, int maxStrelochka)
        {
            ConsoleKeyInfo knopka;
            do
            {
                knopka = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");
                if (knopka.Key == ConsoleKey.UpArrow && position != minStrelocka)
                {
                    position--;

                }
                else if (knopka.Key == ConsoleKey.DownArrow && position != maxStrelochka)
                {
                    position++;

                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return -1;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

            } while (knopka.Key != ConsoleKey.Enter);
            return position;


        }
    }
}
