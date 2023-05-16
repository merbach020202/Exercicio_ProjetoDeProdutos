using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos__Exercicio_
{
    public class Usuario
    {
        int codigo { get; set; }
        string nome { get; set; }
        string email { get; set; }
        string senha { get; set; }
        DateTime DataCadastro;


        public string CadastrarUsuario()
        {
            Console.WriteLine($"Digite seu nome: ");
            nome = Console.ReadLine();
            
            Console.WriteLine($"\nDigite seu email: ");
            email = Console.ReadLine();
            
            Console.WriteLine($"\nDigite sua senha: ");
            senha = Console.ReadLine();
            
            Console.WriteLine($"\nDigite seu código de acesso: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{DataCadastro}");

            return "";
        }

        public void DeletarUsuario()
        {
            Console.WriteLine($"Usuário deletado, cadastre um novo usuário para poder continuar!");
            CadastrarUsuario();
        }
    }
}