using Projeto_de_produtos__Exercicio_;

Marca marca = new Marca();
Usuario usuario = new Usuario();
Login login = new Login();

usuario.CadastrarUsuario();



//INSIRA SEU EMAIL:
//INSIRA SUA SENHA:
//FAZER VALIDACAO PARA VEREFICAR SE A SENHA OU O LOGIN BATEM
//SE ESTIVER CORRETO APARECER O MENU DE OPCOES
//1- CADASTRAR PRODUTO
//2- LISTAR PRODUTO
//3- REMOVER PRODUTO //Digitar o codigo do produto para remover o produto
//4- CADASTRAR MARCA
//5- LISTAR MARCA
//6- REMOVER MARCA
//0- SAIR

int opcao;

Console.WriteLine(@$"
------menu de opções------

1- Cadastrar produto
2- Listar produtos
3- Remover produto
4- Cadastrar marca
5- Listar Marcas
6- Remover marca
0- Sair
");

opcao = int.Parse(Console.ReadLine());

do
{
    switch (opcao)
    {
        case 1:

            break;

        case 2:

            break;

        case 3:
        
            break;

        case 4:

            break;

        case 5:

            break;

        case 6:
        
            break;

        default:
            break;
    }
} while (opcao != 0);










