/*
 Crie um programa que peça 10 números inteiros
e apresente a média, a soma e o menor.
 */
namespace mediaSomaEMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorInteiros = new int[10];
            Console.WriteLine("Entre com os valores de um vetor de 10 posições.");
            for(int i = 0; i < vetorInteiros.Length; i++)
            {
                Console.Write($"Insira o {i+1}° valor do vetor: ");
                if(int.TryParse(Console.ReadLine(), out var valorPosAtual))
                {
                    vetorInteiros[i] = valorPosAtual;
                } else
                {
                    throw new Exception("Não foi possível fazer a conversão de tipos da entrada. ");
                }
            }

            Console.WriteLine($"A soma dos valores do vetor é: {soma(vetorInteiros)}\n" +
                $"O menor valor do vetor é: {menorValor(vetorInteiros)}\n" +
                $"A média dos valores do vetor é: {media(vetorInteiros)}\n");

        }

        public static int menorValor(int[] vetorInteiros)
        {
            return vetorInteiros.Min();
        }
        public static float soma(int[] vetorInteiros)
        {
            float soma = 0.0f;
            foreach(var valor in vetorInteiros)
            {
                soma += valor;
            }
            return soma;
        }

        public static float media(int[] vetorInteiros)
        {
            return (soma(vetorInteiros) / vetorInteiros.Length);
        }
    }
}