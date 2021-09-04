using System;

namespace Tarefa_NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome;
            Console.BackgroundColor = ConsoleColor.Red;
             Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Digite seu nome...: ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            nome = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Red;
             Console.BackgroundColor = ConsoleColor.Red;
             Console.Write("Digite seu sobrenome...: ");
             Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
             sobrenome = Console.ReadLine();
             
            Console.BackgroundColor = ConsoleColor.Green;
             Console.WriteLine($"{nome} {sobrenome}");
            Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");
             Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;



                     }
    }
}
