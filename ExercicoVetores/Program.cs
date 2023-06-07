using System;

namespace ExercicoVetores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Estudantes[] estudantes = new Estudantes[10]; //instancia 10 quartos/ 10 estudantes
            
            Console.WriteLine("Quantos quartos serão alugados? "); 
            int n = int.Parse(Console.ReadLine()); //le quantos quartos serao alugados

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel: {i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quartos = int.Parse(Console.ReadLine());
                estudantes[quartos] = new Estudantes(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + estudantes[i]);
                }
            }
        }
    }
}