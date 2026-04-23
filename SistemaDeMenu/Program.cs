namespace SistemaDeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usuario = { "nome1", "nome2", "nome3", "nome4", "nome5" };
            string[] senha = { "1", "2", "3", "4", "5" };

            bool sairLista = false;

            while (!sairLista)
            {
                Console.Clear();
                Console.WriteLine("1 - Exibir apenas nomes");
                Console.WriteLine("2 - Exibir apenas senhas");
                Console.WriteLine("3 - Exibir nomes e senhas");
                Console.WriteLine("4 - Deletar um usuário");
                Console.WriteLine("x - Sair");

                string entradaListas = Console.ReadLine();
                switch (entradaListas)
                {
                    case "1":
                        //Exibir apenas nomes
                        Console.Clear();
                        Console.WriteLine("\nExibindo todos os usuarios\n");
                        foreach (string nome in usuario)
                        {
                            if (nome == null)
                            {
                                break;
                            }
                            Console.WriteLine(nome);
                        }

                        Console.WriteLine("\nDigite ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case "2":
                        //Exibir apenas senhas
                        Console.Clear();
                        Console.WriteLine("\nExibindo todos as senhas\n");
                        foreach (string senhaAcesso in senha)
                        {
                            if (senhaAcesso == null)
                            {
                                break;
                            }
                            Console.WriteLine(senhaAcesso);
                        }

                        Console.WriteLine("\nDigite ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case "3":
                        //Exibir nome e senha
                        Console.Clear();
                        Console.WriteLine("\nExibindo todos os usuarios\n");
                        for (int i = 0; i < usuario.Length; i++)
                        {
                            if (usuario[i] == null)
                            {
                                break;
                            }
                            Console.WriteLine($"Nome do usuário: {usuario[i]}  senha: {senha[i]}");
                        }

                        Console.WriteLine("\nDigite ENTER para continuar");
                        Console.ReadLine();
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
                            for (int i = 0; i < usuario.Length; i++)
                            {
                                if (delete == "x")
                                {
                                    sairDelete = true;
                                    break;
                                }
                                else if (usuario[i] == null)
                                {
                                    continue;
                                }
                                else if (delete == usuario[i].ToLower())
                                {
                                    usuario[i] = null;
                                    encontrado = true;
                                    sairDelete = true;
                                    break;
                                }
                            }

                            if(!encontrado && !sairDelete)
                            {
                                Console.WriteLine("Usuário não encontrado, tente novamente");
                            }

                            for (int i = 0; i < usuario.Length; i++)
                            {
                                if (usuario[i] == null)
                                {
                                    for (int j = i; j < usuario.Length - 1; j++)
                                    {
                                        usuario[j] = usuario[j + 1];
                                        senha[j] = senha[j + 1];
                                    }
                                    usuario[usuario.Length - 1] = null;
                                    senha[senha.Length - 1] = null;
                                }
                            }
                        }

                        if (encontrado)
                        {
                            Console.WriteLine("\nExibindo todos os usuarios e senhas ATUALIZADOS\n");

                            for (int i = 0; i < usuario.Length; i++)
                            {
                                if (usuario[i] == null)
                                {
                                    break;
                                }
                                Console.WriteLine($"Nome do usuário: {usuario[i]}  senha: {senha[i]}");
                            }

                            Console.WriteLine("\nDigite ENTER para continuar");
                            Console.ReadLine();
                        }
                        break;
                    case "x":
                        sairLista = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
