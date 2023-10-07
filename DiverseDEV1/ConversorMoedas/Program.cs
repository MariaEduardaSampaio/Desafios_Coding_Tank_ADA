using Commom;
using System.Globalization;
using System.Text;

namespace ConversorMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("*****Conversor de moedas*****\n");
                Console.WriteLine("Insira um valor em reais:\n");
                float valorReais = float.Parse(Console.ReadLine());

                verificaValorReais(valorReais);

                float taxaDolares = 5.5f;
                float taxaEuro = 6.5f;
                float valorDolares = valorReais / taxaDolares;
                float valorEuro = valorReais / taxaEuro;


                Console.WriteLine($"Valor em reais: {valorReais.ToString("C", CultureInfo.CurrentCulture)}\n");
                Console.WriteLine($"Valor em dólares: {valorDolares.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}\n");
                Console.WriteLine($"Valor em euros: {valorEuro.ToString("C", CultureInfo.CreateSpecificCulture("es-ES"))}\n");
            }
            catch (Exception e)
            {
                throw new OperationsExceptions(e.Message, e);
            }
        }

        private static void verificaValorReais(float valorReais)
        {
            if (valorReais < 0 )
            {
                throw new ArithmeticException("Não é possível fazer operações com valor menor que zero.");
            }
        }
    }
}