namespace SistemaDeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usuarios = { "Gabriel", "Igor", "Ana" };
            string[] senhas = { "123", "456", "789" };
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
        }
    }
}
