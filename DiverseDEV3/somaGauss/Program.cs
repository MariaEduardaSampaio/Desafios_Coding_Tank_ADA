/*
 Some os números de 1 a 100 a imprima o valor. Feito com soma 
 */
namespace somaGauss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            int valorAtual = 0;
            int soma = 0;
            while (valorAtual < 100)
            {
                valorAtual++;
                soma += valorAtual;
            }
            Console.WriteLine($"O valor da soma de 1 a 100 é {soma}");
             */

            Console.WriteLine("Entre com os valores mínimo e máximo do intervalo: ");

            if (!int.TryParse(Console.ReadLine(), out int valorMin))
            {
                throw new ArgumentException("Falha na tentativa de conversão de tipos.");
            }

            if (!int.TryParse(Console.ReadLine(), out int valorMax))
            {
                throw new ArgumentException("Falha na tentativa de conversão de tipos.");
            }


            if (valorMin > valorMax)
            {
                valorMin = valorMin + valorMax; // a = a + b
                valorMax = valorMin - valorMax; // b = a - b = (a + b) - b = a
                valorMin = valorMin - valorMax; // a = a - b = (a + b) - (a) = b
            }

            int somaIntervalo = somaDeGauss(valorMin, valorMax);
            Console.WriteLine($"A soma dos valores no intervalo de {valorMin} até {valorMax} é {somaIntervalo}");

        }

        public static int somaDeGauss(int valorMin, int valorMax)
        {
            return (valorMin + valorMax) * (valorMax - valorMin + 1) / 2;
        }
    }
}