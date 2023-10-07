/*
 Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma
maneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela
é palíndroma ou não.
 */
namespace VerificacaoPalindromos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com uma palavra ou frase para verificar se é palíndromo ou não:\n");
            string texto = Console.ReadLine();
            bool isPalindromo = false;

            for(int i = 0, j = texto.Length - 1; i < texto.Length && j >= 0; i++, j--)
            {
                if (texto[i].ToString().ToUpper() == texto[j].ToString().ToUpper())
                {
                    isPalindromo = true;
                } else
                {
                    isPalindromo = false;
                }
            }

            if (isPalindromo)
            {
                Console.WriteLine($"'{texto}' é um palíndromo!");
            }
            else
            {
                Console.WriteLine($"'{texto}' não é um palíndromo!");
            }
        }
    }
}