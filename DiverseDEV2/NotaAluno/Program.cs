/*
 
Um aluno realizou três provas de uma determinada disciplina. Levando em consideração o
critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
e caso positivo, que nota o aluno precisará obter para passar de ano.

"Média = (Prova 1 + Prova 2 + Prova 3) / 3"

A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:

"Final = (Média + Exame) / 2"

A média final para a aprovação deve ser igual ou maior que 5,0.
 */

using System.Net.Http.Headers;

namespace NotaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> notas = new List<float>();

            try
            {
                Console.WriteLine("Insira a nota da sua primeira prova: ");
                notas.Add(float.Parse(Console.ReadLine()));
                Console.WriteLine("Insira a nota da sua segunda prova: ");
                notas.Add(float.Parse(Console.ReadLine()));
                Console.WriteLine("Insira a nota da sua terceira prova: ");
                notas.Add(float.Parse(Console.ReadLine()));
                verificaNotas(notas);

                float media = calculaMedia(notas);
                if (media >= 7)
                {
                    Console.WriteLine($"Aluno foi aprovado com uma média de {media} sem o exame final.");
                }
                else
                {
                    Console.WriteLine("Qual a nota do aluno no exame?\n");
                    float notaExame = float.Parse(Console.ReadLine());

                    float notaFinal = (media + notaExame) / 2;
                    if (notaFinal >= 5)
                    {
                        Console.WriteLine($"O aluno foi aprovado no exame final com {notaFinal} pontos.");
                    }
                    else
                    {
                        float notaMinExame = 10 - media;

                        Console.WriteLine($"O aluno precisava tirar no mínimo {notaMinExame} no exame final" +
                                          $"para ficar com a média igual a 5.0 pontos.");
                    }

                }


            }
            catch (FormatException e)
            {
                throw new FormatException(e.Message);

            }



        }

        public static float calculaMedia(List<float> notas)
        {
            float soma = 0;
            foreach (var nota in notas)
            {
                soma += nota;
            }

            return soma / 3;
        }

        public static void verificaNotas(List<float> notas)
        {
            foreach (var nota in notas)
            {
                if (nota < 0)
                {
                    throw new ArgumentException("Nota não pode ser negativa.");
                }
                else if (nota > 10)
                {
                    throw new ArgumentException("Nota não pode ser maior que 10.");
                }
            }
        }
    }
}