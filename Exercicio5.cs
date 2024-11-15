using System.Text.RegularExpressions;

class Exercicio5
{
    static void Main(string[] args)
    {
        Console.Write("Olá senhor, por favor! Digite a placa do veículo sem pontos e virgulas: ");
        string placa = Console.ReadLine();

        string padrao = @"^[A-Za-z]{3}\d{4}$"; 

        bool ehValida = Regex.IsMatch(placa, padrao);

        Console.WriteLine(ehValida ? "É Verdadeiro!" : "É Falso!");
    }
}