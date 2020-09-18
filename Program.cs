using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algo: ");
            string texto = Console.ReadLine();  
            string novoTexto = texto.Replace("r", "l")
                .Replace("R", "L");
            Console.WriteLine(novoTexto);
        }
    }
}
