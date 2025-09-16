using System;

namespace Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de números
            int[] listaNumeros = { 1, 3, 5, 6};

            Console.WriteLine("Digite a senha de 4 números utiilizada por Gwen Stacy, no primeiro filme do Espetacular Homem Aranha, para executar a evacuação da Oscorp +" +
                "os números deve estrar separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' ');
            int[] numeros = Array.ConvertAll(entrada, int.Parse);

            // Verifica se o usuário digitou 4 números
            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("D");
                return;
            }

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (numeros[i] == listaNumeros[i])
                {

                    
                    if (i == listaNumeros.Length - 1)
                    {
                        Console.WriteLine("Senha correta");
                    }
                }
                else
                {
                    Console.WriteLine($"Dígito {i + 1} incorreto");
                }
            }

        }
    }
}