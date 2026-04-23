using System.Threading.Channels;

namespace SistemaDeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usuarios = new string[5];
            string[] senhas = new string[5];
            int total = 0;
            string opcao = "";
 
            while (opcao.ToLower() != "x")
            {

            Console.WriteLine("====MENU====");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Visualizar");
            Console.WriteLine("3 - Buscar cadastro");
            Console.WriteLine("4 - Deletar cadastro");
            Console.WriteLine("5 - Edição");
            Console.WriteLine("X - Sair do programa");
            Console.WriteLine("Opção:");

                opcao = Console.ReadLine();
                int contador = 0;
                switch (opcao)
                {
                    case "1":

                        if (contador > usuarios.Length) 
                        {
                            Console.WriteLine("Número máximo de usuários atingido!");
                            break;
                        }
                        //cadastro de usuario
                        Console.WriteLine("Insira seu usuário: ");

                            usuarios[contador] = Console.ReadLine();
                            
                        

                        //senha
                        Console.WriteLine("Insira sua senha: ");

                       
                            senhas[contador] = Console.ReadLine();
                            
                       
                        //final
                        Console.WriteLine("Usuário cadastrado com sucesso!");
                        contador++;
                        break;

                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "x":
                        break;

                    default:
                        break;
                }
            }




        }
    }
}