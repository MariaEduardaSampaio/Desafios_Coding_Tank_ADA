using Commom;

namespace CalculadoraGorjeta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****Calculadora de gorjeta*****\n");

            try
            {
                Console.WriteLine("Insira o valor total da conta do restaurante:\n");
                float precoConta = float.Parse(Console.ReadLine());
                verificarSeValorMenorQueZero(precoConta);

                Console.WriteLine("Insira a porcentagem de gorjeta desejada:\n");
                float gorjeta = float.Parse(Console.ReadLine());
                verificarSeValorMenorQueZero(gorjeta);

                float valorGorjeta = precoConta * (gorjeta / 100.0f);
                float valorTotal = precoConta + valorGorjeta;
                Console.WriteLine($"O valor da gorjeta é R${valorGorjeta} e o total a ser pago é R${valorTotal}.");
            }
            catch (Exception e)
            {
                throw new OperationsExceptions(e.Message, e);
            }
        }

        private static void verificarSeValorMenorQueZero(float valor)
        {
            if (valor < 0)
            {
                throw new Exception("Valor menor que 0 é inválido.");
            }
        }
    }
}