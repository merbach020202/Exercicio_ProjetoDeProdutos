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

        public Produto()
        {
        }

        public Produto(int codigo, string nomeProduto, float preço)
        {
            this.NomeProduto = nomeProduto;
            this.Preco = preço;
            this.Codigo = codigo;
        }

        List<Produto> ListaDeProdutos = new List<Produto>();

        public void cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"\nDigite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"\nDigite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nDigite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            // instanciar o objeto
            //receber os dados e cadastrar nesse objeto
            //amrazenar o objeto na lista
            ListaDeProdutos.Add(novoProduto);

        }


        public void adicionar(Produto novoProduto)
        {
            ListaDeProdutos.Add(novoProduto);
        }

        public void listar()
        {
            foreach (var produtos in ListaDeProdutos)
            {
                Console.WriteLine($"\nNome: {produtos.NomeProduto}, Preço: {produtos.Preco:c}, Código: {produtos.Codigo} ");
                Console.ReadKey();
            }
            //aqui vai a lógica
            //exibir os objetos cadastrados na lista
        }
        
        public void remover( int codigo )
        {
            ListaDeProdutos.Find(items => items.Codigo == codigo);
            Console.WriteLine($"Produto removido : {codigo}");
        }
        
    }
}

