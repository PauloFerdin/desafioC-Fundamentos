class Exercicio4
{
    static void Main(string[] args)
    {

        Console.WriteLine("Olá senhor! digite uma frase para que possamos contar a quantidade de letras nessa frase:");
        string text = Console.ReadLine();

        int numeroDeLetras = text.Count(char.IsLetter);

        Console.WriteLine($"A frase contém {numeroDeLetras} letras");
    }
}