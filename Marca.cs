using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos__Exercicio_
{
    public class Marca
    {
        int codigo { get; set; }
        string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }
        List<Marca> MarcaLista = new List<Marca>();
        
        public string CadastrarMarca()
        {
            Console.WriteLine($"Digite a marca do produto: ");
            NomeMarca = Console.ReadLine();
            
            Console.WriteLine($"\nDigite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\n{DataCadastro}");
            
            return "";
        }
        public void adicionar( Marca marca )
        {
            MarcaLista.Add(marca);
        }

        public void Listar()
        {
            foreach (Marca M in MarcaLista)
            {
                
            }
            
        }
        public void DeletarUsuario()
        {
            Console.WriteLine($"Marca deletada, cadastre um novo usuário para poder continuar!");
            CadastrarMarca();
        }
    }
}