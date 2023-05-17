using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos__Exercicio_
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Cadastrar();
        }


        public void Cadastrar()
        {
            this.DataCadastro = DateTime.Now;

            Console.WriteLine(@$"
                        CADASTRO");
            
            Console.WriteLine($"Digite seu nome: ");
            Nome = Console.ReadLine();
            
            Console.WriteLine($"\nDigite seu email: ");
            Email = Console.ReadLine();
            
            Console.WriteLine($"\nDigite sua senha: ");
            Senha = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nData do cadastro: {DataCadastro}");
            Console.ResetColor();

            Console.WriteLine($"\nAperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public void DeletarUsuario()
        {
            Console.WriteLine($"Usuário deslogado, cadastre ou faça login para poder continuar!");
            Cadastrar();
        }
    }
}