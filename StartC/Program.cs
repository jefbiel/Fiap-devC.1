using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String aluno1, aluno2;
            int age1, age2;

            Console.WriteLine("Insira o nome do primeiro aluno:");
            aluno1 = Console.ReadLine();

            Console.WriteLine("Insira a idade do primeiro aluno:");
            age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome do segundo aluno:");
            aluno2 = Console.ReadLine();

            Console.WriteLine("Insira a idade do segundo aluno:");
            age2 = int.Parse(Console.ReadLine());

            if (age1 == age2)
            {
                Console.WriteLine("Ambos alunos tem a mesma idade.");
            }
            if (age1 > age2)
            {
                Console.WriteLine($"{aluno1} é mais velho que {aluno2}.");
            }
            if (age1 < age2)
            {
                Console.WriteLine($"{aluno2} é mais velho que {aluno1}.");
            }
        }
    }
}