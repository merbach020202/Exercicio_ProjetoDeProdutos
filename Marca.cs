using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos__Exercicio_
{
    public class Marca
    {
        public string NomeMarca { get; set; }
        public int codigo { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Marca> ListaDeMarcas = new List<Marca>();
        
        //instanciar o objeto
        //receber os dados e cadastrar nesse objeto 
        //armazenar o objeto na lista
        // retornar o objeto criado
        public Marca Cadastrar()
        {
            //instanciar o objeto
            Marca marca = new Marca();

            //receber os dados e cadastrar nesse objeto
            Console.WriteLine($"Digite o nome da marca do produto: ");
            NomeMarca = Console.ReadLine();

            Console.WriteLine($"\nDigite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{DataCadastro}");

            return marca;
        }

        void adicionar(Marca marca)
        {
            ListaDeMarcas.Add(marca);
        }


        public void Listar()
        {
            foreach (Marca M in ListaDeMarcas)
            {
                Console.WriteLine($"Marca: ");
                
            //aqui vai a lógica
            }
            //exibir os objetos cadastrados na lista

        }
        public void deletar(int codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo
        }
    }
}