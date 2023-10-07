using System.Globalization;

namespace VerificadorMulta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva a quantidade em kg de pesca: ");
                float pesoPeixes = float.Parse(Console.ReadLine());
                verificaPesoPeixes(pesoPeixes);
                float excesso = verificaExcesso(pesoPeixes);
                float preco = verificaMulta(pesoPeixes, excesso);
                Console.WriteLine($"A quantidade de quilos excedentes é {excesso} e a multa é de {preco.ToString("C", CultureInfo.CurrentCulture)}");

            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException(e.Message);
            }
            catch (FormatException e)
            {
                throw new FormatException(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        static private void verificaPesoPeixes(float pesoPeixes)
        {
            if (pesoPeixes < 0)
            {
                throw new ArgumentException("Peso não pode ser negativo.");
            }
            else if (pesoPeixes == null)
            {
                throw new ArgumentNullException("Peso não pode ser nulo.");
            }
        }

        static private float verificaMulta(float pesoPeixes, float excesso)
        {
            float valorMultaPorQuilo = 4;
            if (pesoPeixes <= 50)
            {
                return 0;
            }
            else
            {
                return valorMultaPorQuilo * excesso;
            }
        }

        static private float verificaExcesso(float pesoPeixes)
        {
            if (pesoPeixes >= 50)
                return pesoPeixes - 50;
            else
                return 0;
        }
    }
}