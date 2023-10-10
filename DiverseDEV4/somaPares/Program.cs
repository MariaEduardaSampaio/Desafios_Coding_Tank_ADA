/*
 01 - Escreva um programa em C# que calcule a soma dos números pares em um intervalo de números inteiros especificado pelo usuário.
 */

namespace somaPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dois valores para um intervalo de números inteiros");
            int valorMin, valorMax;

            while (!int.TryParse(Console.ReadLine(), out valorMin))
            {
                Console.WriteLine("Entre com um valor inteiro. Tente novamente: ");
            }

            while(!int.TryParse(Console.ReadLine(),out valorMax))
            {
                Console.WriteLine("Entre com um valor inteiro. Tente novamente: ");
            }

            if (valorMin > valorMax)
            {
                int aux = valorMin;
                valorMin = valorMax;
                valorMax = aux;
            }

            int passo = valorMin;
            int soma = 0;
            while (passo <= valorMax)
            {
                if (passo % 2 == 0)
                {
                    soma += passo;
                }
                passo++;
            }

            Console.WriteLine($"A soma dos valores pares neste intervalo é igual a {soma}.");
        }


    }
}