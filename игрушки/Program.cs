using System.ComponentModel.Design;

namespace игрушки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo knopk ;
            knopk = Console.ReadKey();
            do
            {
                int position=1;
                position = Menu.ocnovnoe(position);
                int positio= Menu.dop (position);
            } while (knopk.Key != ConsoleKey.Escape);
            
        }
    }
}
