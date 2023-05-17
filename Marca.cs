using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos__Exercicio_
{
    public class Marca
    {
        public int codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Marca> ListaDeMarcas = new List<Marca>();
        
        public Marca Cadastrar()
        {
            //instanciar o objeto
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite a marca do produto: ");
            NomeMarca = Console.ReadLine();
            
            Console.WriteLine($"\nDigite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"\n{DataCadastro}");
            
            //instanciar o objeto
            //receber os dados e cadastrar nesse objeto 
            //armazenar o objeto na lista
            // retornar o objeto criado
            return novaMarca;
        }

        public void Listar()
        {
            // foreach (Marca M in ListaDeMarcas)
            // {
                
            // }

            //aqui vai a lógica
            //exibir os objetos cadastrados na lista
            
        }
        public void Deletar( int codigo )
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo
        }
    }
}