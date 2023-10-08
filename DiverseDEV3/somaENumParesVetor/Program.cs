/*
 Faça um algoritmo que leia números até o usuário digitar 0, após
finalizar, mostre quantos números lidos, a soma e quantos são pares.
 */

namespace NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 0 para encerrar a operação e imprimir quantos " +
                              "números foram lidos, sua soma e quantos são pares.");

            int[] vetor = new int[1];
            int tamanhoAtualVetor = 1;
            int indice = 0;
            int numero = 1;
            while (numero != 0)
            {
                Console.WriteLine("\nDigite um número para inserir no vetor: ");
                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    throw new Exception("Não foi possível fazer a conversão de tipos.");
                }

                if (indice == tamanhoAtualVetor)
                {
                    Array.Resize(ref vetor, tamanhoAtualVetor + 1);
                    tamanhoAtualVetor++;
                }

                vetor[indice] = numero;
                indice++;
            }

            Array.Resize(ref vetor, tamanhoAtualVetor - 1);

            Console.WriteLine($"\n\nForam lidos {vetor.Length} números, sendo estes:\n" +
                $"{string.Join(", ", vetor)}\n" +
                $"A soma de todos os números é igual a {somaValores(vetor)} " +
                $"e existem {verificaNumerosPares(vetor)} números pares nesta lista.\n\n");
        }

        public static int verificaNumerosPares(int[] vetor)
        {
            int qntdPares = 0;
            foreach (var valor in vetor)
            {
                if (valor % 2 == 0)
                {
                    qntdPares++;
                }
            }
            return qntdPares;
        }

        public static int somaValores(int[] vetor)
        {
            int soma = 0;
            foreach (var valor in vetor)
            {
                soma += valor;
            }
            return soma;
        }
    }
}