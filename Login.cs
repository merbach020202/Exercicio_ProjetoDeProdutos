using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_de_produtos__Exercicio_;



namespace Projeto_de_produtos__Exercicio_
{
    public class Login
    {
        public bool logado;

        public Login()
        {
            Usuario user = new Usuario();

            //validar se está logado
            logar(user);

            if (logado)
            {
                GerarMenu();
            }

        }

        public void logar(Usuario usuario)
        {

            do
            {
                Console.WriteLine(@$"
                            LOGIN");

                Console.WriteLine($"Digite seu email: ");
                string email = Console.ReadLine();

                Console.WriteLine($"\nDigite sua senha: ");
                string senha = Console.ReadLine();

                if (email == usuario.Email && senha == usuario.Senha)
                {
                    this.logado = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nLogin efetuado com sucesso!");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else
                {
                    this.logado = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nLogin ou senha incorretos!");
                    Console.ResetColor();
                }
            } while (logado == false);


        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
------menu de opções------

[1]- Cadastrar produto
[2]- Listar produtos
[3]- Remover produto
--------------------
[4]- Cadastrar marca
[5]- Listar Marcas
[6]- Remover marca
--------------------
[0]- Sair
");

                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        //cadastrar
                        produto.cadastrar();
                        break;

                    case "2":
                        //listar
                        produto.listar();
                        break;

                    case "3":
                        //remover
                        produto.deletar(produto);                        
                        break;

                    case "4":
                        //cadastra
                        marca.Cadastrar();
                        break;

                    case "5":
                        //listar
                        marca.Listar();
                        break;

                    case "6":
                        //remover
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int CodigoMarca = int.Parse(Console.ReadLine());

                        produto.deletar(marca);
                        break;

                    case "0":
                        //remover
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nApp encerrado!");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine($"Opção inválida");

                        break;
                }
            } while (opcao != "0");
        }
    }
}




