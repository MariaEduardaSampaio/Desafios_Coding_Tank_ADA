namespace ClassificacaoNatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                verificaIdade(idade);

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Categoria: Infantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Categoria: Infantil B");

                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Categoria: Juvenil A");

                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Categoria: Juvenil B");

                }
                else
                {
                    Console.WriteLine("Categoria: Adulto");
                }
                Console.ReadKey();
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
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

        static private void verificaIdade(int idade)
        {
            if (idade < 0)
            {
                throw new ArgumentException("Idade não pode ser negativa.");
            }
            else if (idade < 5)
            {
                throw new ArgumentException("Idade deve ser a partir de 5 anos.");
            }
        }
    }
}