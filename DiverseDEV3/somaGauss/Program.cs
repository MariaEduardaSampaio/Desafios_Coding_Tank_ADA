/*
 Some os números de 1 a 100 e imprima o valor.
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

            Console.WriteLine("Entre com o valor mínimo do intervalo: ");

            int valorMin, valorMax;
                bool deuCerto = true;
            do
            {
                deuCerto = int.TryParse(Console.ReadLine(), out valorMin);
            } while (!deuCerto);

            Console.WriteLine("Entre com o valor máximo do intervalo: ");
            do
            {
                deuCerto = int.TryParse(Console.ReadLine(), out valorMax);
            } while (!deuCerto);


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