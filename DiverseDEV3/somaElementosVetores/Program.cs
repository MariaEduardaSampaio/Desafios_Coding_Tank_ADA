/*
 Exercício 01: 
Faça um algoritmo que construa dois vetores A e B de 10 elementos e,
a partir deles, crie um vetor C, composto pela somados elementos, sendo: 

C[1] = A[1] + B[9], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc. 
 */

namespace somaElementosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores do primeiro vetor");
            float[] vetorA = new float[10];
            float[] vetorB = new float[10];

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}° valor: ");
                vetorA[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Entre com os valores do segundo vetor");
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}° valor: ");
                vetorB[i] = float.Parse(Console.ReadLine());
            }

            float[] vetorC = new float[10];
            for (int i = 0; i < vetorC.Length; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[9 - i];
            }
            Console.WriteLine($"O vetor C é igual a: {string.Join(", ", vetorC)}" );
        }
    }
}