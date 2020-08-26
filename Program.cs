using System;
using ExercicioNotas.Objetos;

namespace ExercicioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Aluno, digite seu nome: ");
            var nomeAluno = Console.ReadLine();

            //instancear novo aluno

            Console.WriteLine($"Bem-Vindo {nomeAluno}!");

            for (int i = 1; i <= 3; i++)
            {
                 Console.WriteLine($"Por favor insira sua {i}º disciplina: ");   
                var nomeDisciplina = Console.ReadLine();
                
                var disciplina = new Disciplina(nomeDisciplina);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"Insira a Nota {j} da Disciplina {disciplina.Nome}: ");
                }

                Console.WriteLine(disciplina);

                //Adicionar essa disciplina a aluno
            }

            //Exibir a média final
        }

    }
}
