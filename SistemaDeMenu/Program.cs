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
                        //Exibir nome e senha
                        Console.Clear();
                        Console.WriteLine("\nExibindo todos os usuarios\n");
                        for (int i = 0; i < usuarios.Length; i++)
                        {
                            if (usuarios[i] == null)
                            {
                                break;
                            }
                            Console.WriteLine($"Nome do usuário: {usuarios[i]}  senha: {senhas[i]}");
                        }

                        Console.WriteLine("\nDigite ENTER para continuar");
                        Console.ReadLine();
                        break;
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
                    case "4":

                        //Deleta um usuário
                        Console.Clear();
                        bool sairDelete = false;
                        bool encontrado = false;

                        while (!sairDelete)
                        {
                            Console.WriteLine("Delete um usuário digitando o nome ou X para sair\n");
                            string delete = Console.ReadLine().ToLower();
                            for (int i = 0; i < usuarios.Length; i++)
                            {
                                if (delete == "x")
                                {
                                    sairDelete = true;
                                    break;
                                }
                                else if (usuarios[i] == null)
                                {
                                    continue;
                                }
                                else if (delete == usuarios[i].ToLower())
                                {
                                    usuarios[i] = null;
                                    encontrado = true;
                                    sairDelete = true;
                                    break;
                                }
                            }

                            if (!encontrado && !sairDelete)
                            {
                                Console.WriteLine("Usuário não encontrado, tente novamente");
                            }

                            for (int i = 0; i < usuarios.Length; i++)
                            {
                                if (usuarios[i] == null)
                                {
                                    for (int j = i; j < usuarios.Length - 1; j++)
                                    {
                                        usuarios[j] = usuarios[j + 1];
                                        senhas[j] = senhas[j + 1];
                                    }
                                    usuarios[usuarios.Length - 1] = null;
                                    senhas[senhas.Length - 1] = null;
                                }
                            }
                        }

                        if (encontrado)
                        {
                            Console.WriteLine("\nExibindo todos os usuarios e senhas ATUALIZADOS\n");

                            for (int i = 0; i < usuarios.Length; i++)
                            {
                                if (usuarios[i] == null)
                                {
                                    break;
                                }
                                Console.WriteLine($"Nome do usuário: {usuarios[i]}  senha: {senhas[i]}");
                            }

                            Console.WriteLine("\nDigite ENTER para continuar");
                            Console.ReadLine();
                        }
                        break;
                    case "5":
                        string novaSenha;
                        string novoUsuario;

                        Console.WriteLine("Informe qual usario gostaria de editar");

                        if (usuarios.Contains(Console.ReadLine()))
                        {

                            Console.WriteLine("Informe qual dado quer alterar: ");
                            Console.WriteLine("1 - Nome");
                            Console.WriteLine("2 - Senha");
                            Console.WriteLine("3 - Sair");

                            string resposta = Console.ReadLine();

                            switch (resposta)
                            {
                                case "1":

                                    Console.WriteLine("Favor informar novo usuario: ");
                                    novoUsuario = Console.ReadLine();
                                    Console.WriteLine("Usuario atualizado com sucesso");

                                    break;

                                case "2":
                                    Console.WriteLine("Favor informar nova senha: ");
                                    novaSenha = Console.ReadLine();
                                    Console.WriteLine("Senha atualizada com sucesso");

                                    break;

                                case "3":
                                    Console.WriteLine("Saindo...");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Usuario nao encontrado");

                        }
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
