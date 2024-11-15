using System;

class Exercicio3
{
    static void Main(string[] args)
    {

        Console.WriteLine("Olá senhor! Tudo certo? Para começarmos poderia por favor, digitar o primeiro numero a ser usado para calcular:");
        double num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("E agora, por favor, digite o segundo numero que usaremos para calcular:");

        double num2 = Convert.ToInt32(Console.ReadLine());

        double soma = num1+num2;

        Console.WriteLine("A soma entre os dois é: " + soma);

        double subtracao = num1-num2;

        Console.WriteLine("A subtração é: " + subtracao);

        double multi = num1*num2;

        Console.WriteLine("A multiplicação é: " + multi);

        double divi = num1 / num2;

        Console.WriteLine("A divisão é: " + divi);

        double media = soma / 2;

        Console.WriteLine("A media é: " + media);
    }
}