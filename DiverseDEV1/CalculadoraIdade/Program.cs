using Commom;

namespace CalculadoraIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Calculadora de idade*****\n");
            try
            {
                int anoAtual = DateTime.Now.Year;

                Console.WriteLine("Escreva sua data de nascimento:\n");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                int idade = anoAtual - dataNascimento.Year;

                if (dataNascimento.Month > DateTime.Now.Month && dataNascimento.Day > DateTime.Now.Day)
                    idade--;
                
                verificaDataNascimento(dataNascimento);

                Console.WriteLine($"Sua idade é: {idade}");
            }
            catch (Exception e)
            {
                throw new OperationsExceptions(e.Message, e);
            }

        }

        private static void verificaDataNascimento(DateTime birthDate)
        {
            if (birthDate.Year > DateTime.Now.Year)
            {
                throw new Exception("Ano de nascimento maior que ano atual.");
            }
            else if (birthDate.Year < 0)
            {
                throw new Exception("Ano de nascimento negativo é inválido.");
            }
            else if (birthDate > DateTime.Now)
            {
                throw new Exception("Data de nascimento posterior ao dia atual.");
            }
        }
    }
}