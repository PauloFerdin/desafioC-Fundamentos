using System;

class exercicio2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá senhor! Tudo certo? Para começarmos poderia por favor, digitar seu primeiro nome aqui:");
        string nome = Console.ReadLine();

        Console.WriteLine("E agora, por favor, digite seu sobrenome aqui:");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("Olá " + nome + " " + sobrenome + " !! Seja bem-vindo!");
    }
}

