namespace SistemaDeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usuarios = { "João", "Maria", "Pedro" };

            Console.WriteLine("===MENU===");
            string opcao = "";

            while (opcao.ToLower() != "x")
            {
                Console.Write("3 - Buscar um nome \nx - Sair do programa \nDigite uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "3":
                        Console.Write("Digite o nome que deseja buscar: ");
                        string nomeBusca = Console.ReadLine();
                        bool encontrado = false;

                        for (int i = 0; i < usuarios.Length; i++)
                        {
                            if (nomeBusca.ToLower() == usuarios[i].ToLower())
                            {
                                Console.WriteLine($"Nome encontrado: {usuarios[i]}\n");
                                encontrado = true;
                            }
                        }
                        if (encontrado == false)
                        {
                            Console.WriteLine("Nome não encontrado!\n");
                        }
                        break;

                    case "x":
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}