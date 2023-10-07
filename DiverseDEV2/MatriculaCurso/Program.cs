/*
Crie um algoritmo que dê um leque de opções de cursos para o usuário
escolher e qual turma ele poderá ingressar, usando o conceito
de "Switch-Case" na linguagem CSharp.
 */

namespace MatriculaCurso
{
    internal class Program
    {
        public static void listaCursos(List<string> lista)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Curso: {lista[i]}\n" +
                                  $"Código: {i + 1}\n");
            }
        }
        static void Main(string[] args)
        {
            List<string> cursos = new List<string>();
            cursos.Add("Ciência da Computação");
            cursos.Add("Sistemas de Informação");
            cursos.Add("Engenharia da Computação");
            cursos.Add("Engenharia de Sistemas");
            cursos.Add("Análise e Desenvolvimento de Sistemas");

            listaCursos(cursos);

            Console.WriteLine("Escolha pelo código o curso que deseja se matricular: ");
            int codigoCurso = int.Parse(Console.ReadLine());

            switch(codigoCurso)
            {
                case 1:
                    Console.WriteLine($"Parabéns! Você escolheu {cursos.ElementAt(codigoCurso - 1)}");
                    break;

                case 2:
                    Console.WriteLine($"Parabéns! Você escolheu {cursos.ElementAt(codigoCurso - 1)}.");
                    break; 
                case 3:
                    Console.WriteLine($"Parabéns! Você escolheu {cursos.ElementAt(codigoCurso - 1)}.");
                    break;
                case 4:
                    Console.WriteLine($"Parabéns! Você escolheu {cursos.ElementAt(codigoCurso - 1)}." +
                                      $"\nSpoiler: É a melhor graduação, recomendo!");
                    break;
                case 5:
                    Console.WriteLine($"Parabéns! Você escolheu {cursos.ElementAt(codigoCurso - 1)}.");
                    break;

                default:
                    Console.WriteLine("Você não escolheu uma opção de curso válida.");
                    break;
            }

        }
    }
}