using System;

namespace Exercicio2___Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Aluno, digite seu nome: ");
            string nome = Console.ReadLine(); 

            Console.WriteLine($"Bem-Vindo {nome}, por favor insira sua nota: ");
            decimal pedindonota = Console.Read();
        }

    }
}
