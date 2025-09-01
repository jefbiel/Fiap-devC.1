    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int altura = 20;   // Define quantas linhas a pirâmide terá
            int linha = 1;     // Começa desenhando pela primeira linha

            while (linha <= altura)
            {
                // Para alinhar a pirâmide ao centro, imprimimos espaços antes dos símbolos
                for (int i = 0; i < (altura - linha); i++)
                {
                    Console.Write(" ");  // Espaço para empurrar os símbolos à direita
                }

                // Agora desenhamos os símbolos '/' que formam a pirâmi
                // de nesta linha
                for (int i = 0; i < (2 * linha - 1); i++)
                {
                Console.Write("/");  // Imprime o símbolo da pirâmide
                }
                // Pula para a próxima linha
                Console.WriteLine();     

                // Avança para a próxima linha da pirâmide
                linha++;                
            }
        }
    }
