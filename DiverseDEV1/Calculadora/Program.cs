using Calculadora;
using Commom;

namespace Calculadora;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Calculadora*****\n");

        float valor1 = 0, valor2 = 0, soma = 0, subtracao = 0, multiplicacao = 0, divisao = 0;

        Console.WriteLine("Escreva dois números para obter a soma, subtração, mult e divisão: \n");

        try
        {
            valor1 = float.Parse(Console.ReadLine());
            valor2 = float.Parse(Console.ReadLine());

            soma = Operacoes.somar(valor1, valor2);
            subtracao = Operacoes.subtrair(valor1, valor2);
            multiplicacao = Operacoes.multiplicar(valor1, valor2);
            divisao = Operacoes.dividir(valor1, valor2);

            Console.WriteLine($"Soma: {valor1} + {valor2} = {soma}");
            Console.WriteLine($"Subtração: {valor1} - {valor2} = {subtracao}");
            Console.WriteLine($"Divisão: {valor1} / {valor2} = {divisao}");
            Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {multiplicacao}");
        }
        catch (ArithmeticException e)
        {
            throw new OperationsExceptions(e.Message, e);
        }
        catch(FormatException e)
        {
            throw new OperationsExceptions(e.Message, e);
        }
        catch(Exception e)
        {
            throw new OperationsExceptions(e.Message, e);
        }
    }
}
