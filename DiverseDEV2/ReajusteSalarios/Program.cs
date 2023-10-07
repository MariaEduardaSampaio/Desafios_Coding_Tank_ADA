/*
As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e 
lhe contraram para desenvolver o programa que calculará os reajustes.
Faça um programa que recebe o salário de um colaborador e o reajuste segundo o seguinte 
critério, baseado no salário atual:    
    - salários até R$ 280,00 (incluindo) : aumento de 20%
    - salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
    - salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
    - salários de R$ 1500,00 em diante : aumento de 5%

Após o aumento ser realizado, informe na tela:
    - o salário antes do reajuste;
    - o percentual de aumento aplicado;
    - o valor do aumento;
    - o novo salário, após o aumento.
 */

using System.Globalization;

namespace ReajusteSalarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário do funcionário: ");
            float salario = float.Parse(Console.ReadLine());
            float aumento = 0.0f;
            try
            {
                if (salario > 0 && salario <= 280)
                {
                    aumento = 0.20f;
                }
                else if (salario > 280 && salario <= 700)
                {
                    aumento = 0.15f;
                }
                else if (salario > 700 && salario <= 1500)
                {
                    aumento = 0.1f;
                }
                else if (salario > 1500)
                {
                    aumento = 0.05f;
                }
                else if (salario <= 0)
                {
                    throw new Exception("Salário não pode ser 0 ou negativo.");
                }

                float valorAumento = aumento * salario;
                float novoSalario = valorAumento + salario;

                Console.WriteLine($"Salário atual: {salario.ToString("C", CultureInfo.CurrentCulture)}\n" +
                                  $"Percentual de aumento aplicado: {aumento * 100}%\n" +
                                  $"Valor de aumento: {valorAumento.ToString("C", CultureInfo.CurrentCulture)}\n" +
                                  $"Novo salário: {novoSalario.ToString("C", CultureInfo.CurrentCulture)}\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}