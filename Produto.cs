using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos__Exercicio_
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastroPor { get; set; }


        List<Produto> ListaDeProdutos = new List<Produto>();
        public void cadastrar()
        {
            Console.WriteLine($"Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço do produto: ");
            Preco = float.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite o código do produto: ");
            Codigo = int.Parse(Console.ReadLine());

           // instanciar o objeto
           //receber os dados e cadastrar nesse objeto
           //amrazenar o objeto na lista
        }
        public void listar()
        {
            //aqui vai a lógica
            //exivir os objetos cadastrados na lista
        }
        public void deletar( int Codigo )
        {
            //aqui vai a lógica
            // buscar um objeto na lista pelo seu código
            //removê-lo
        }
    }
}
