/*
 02 - Escreva um programa em C# que gere e exiba os primeiros N termos da sequência de Fibonacci, onde N é especificado pelo usuário.
 */

using System;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o n-ésimo termo que você deseja que a sequência de Fibonacci seja impressa: ");
            int termo;
            while (!int.TryParse(Console.ReadLine(), out termo) || termo <= 0)
            {
                Console.WriteLine("Digite um número inteiro positivo.");
            }

            try
            {
                fibonacci(termo);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao executar o fibonacci: {e.Message}");
            }

        }

        public static void fibonacci(int n)
        {
            int penNum = 0;
            int numAtual = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.Write(penNum + " ");

                int antePenultimo = penNum;
                penNum = numAtual;
                numAtual = antePenultimo + penNum;
            }
        }
    }
}