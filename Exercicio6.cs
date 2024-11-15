class Exercicio6
{
    static void Main(string[] args)
    {
        bool continuar = true; 

        while (continuar)
        {
            
            Console.WriteLine("\nEscolha o formato para exibir a data atual:");
            Console.WriteLine("1 - Formato completo (dia da semana, dia, mês e ano)");
            Console.WriteLine("2 - Apenas data (dd/MM/yyyy)");
            Console.WriteLine("3 - Apenas hora (HH:mm:ss)");
            Console.WriteLine("4 - Formato internacional (yyyy-MM-dd)");
            Console.WriteLine("5 - Formato personalizado (dd de MMMM de yyyy)");
            Console.WriteLine("6 - Sair");

            
            Console.Write("Digite o número da sua escolha: ");
            string escolha = Console.ReadLine();

            
            DateTime dataAtual = DateTime.Now;

            
            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Data no formato completo: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy"));
                    break;
                case "2":
                    Console.WriteLine("Apenas data: " + dataAtual.ToString("dd/MM/yyyy"));
                    break;
                case "3":
                    Console.WriteLine("Apenas hora: " + dataAtual.ToString("HH:mm:ss"));
                    break;
                case "4":
                    Console.WriteLine("Formato internacional: " + dataAtual.ToString("yyyy-MM-dd"));
                    break;
                case "5":
                    Console.WriteLine("Formato personalizado: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));
                    break;
                case "6":
                    Console.WriteLine("Saindo... Até logo!");
                    continuar = false; 
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            
            if (continuar)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                 
            }
        }
    }
}