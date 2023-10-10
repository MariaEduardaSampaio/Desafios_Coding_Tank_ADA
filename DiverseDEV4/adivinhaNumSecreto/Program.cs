/*
 03 - Escreva um programa em C# que solicite ao usuário que adivinhe um número secreto entre 1 e 100. O programa deve gerar aleatoriamente 
o número secreto e fornecer dicas sobre se o palpite do usuário é maior ou menor do que o número secreto. O programa deve continuar pedindo 
palpites até que o usuário adivinhe corretamente o número secreto.
 */

namespace adivinhaNumSecreto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minimo = 1;
            int maximo = 100;
            int numeroAleatorio = random.Next(minimo, maximo + 1);

            Console.WriteLine($"Entre com um número entre {minimo} e {maximo} para adivinhar o número secreto.");

            int chute = 0, tentativas = 0;

            try
            {
                while (chute != numeroAleatorio)
                {
                    Console.Write("Chute: ");
                    bool deuCerto = int.TryParse(Console.ReadLine(), out chute);

                    while (!deuCerto || chute < minimo || chute > maximo)
                    {
                        Console.WriteLine($"Número inválido. Entre com um número inteiro entre {minimo} e {maximo}. ");
                        Console.Write("Chute: ");
                        deuCerto = int.TryParse(Console.ReadLine(), out chute);
                    }
                    Console.WriteLine("");

                    tentativas++;
                    if (chute < numeroAleatorio)
                    {
                        Console.WriteLine($"O número aleatório é maior que {chute}");
                    }
                    else if (chute > numeroAleatorio)
                    {
                        Console.WriteLine($"O número aleatório é menor que {chute}");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns!! Você acertou com {tentativas} tentativas, o número aleatório é {numeroAleatorio}!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}