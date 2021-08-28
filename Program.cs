using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string Texto;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite o seu texto: ");
            Console.ResetColor();
            Texto = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Texto com Leet: ");
            Console.ResetColor();
            Console.WriteLine(Texto
                            .Replace("a","4")
                            .Replace("A","4")
                            .Replace("e","3")
                            .Replace("E","3")
                            .Replace("i","1")
                            .Replace("I","1")
                            .Replace("l","1")
                            .Replace("L","1")
                            .Replace("o","0")
                            .Replace("O","0")
                            .Replace("t","7")
                            .Replace("T","7")
                            .Replace("s","5")
                            .Replace("S","5"));
            Console.WriteLine();

        }
    }
}
