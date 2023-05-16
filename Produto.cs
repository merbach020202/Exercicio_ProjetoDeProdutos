using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos__Exercicio_
{
    public class Produto
    {
        int codigo { get; set; }
        string NomeProduto { get; set; }
        float preco { get; set; }
        string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }
        string cadastro;

        List<Produto> produto = new List<Produto>();
        public void cadastrar()
        {
           
        }
        public void listar()
        {

        }
        public void deletar()
        {

        }
    }
}