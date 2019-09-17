using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Program
    {
      private static  List<Dados> listaDados = new List<Dados>();
        static void Main(string[] args)
        {

            Boolean continuar = true;

            do
            {
                Console.WriteLine(); Console.WriteLine();

                Console.WriteLine("Menu Cadastro");
                Console.WriteLine("1-Incluir");
                Console.WriteLine("2-Alterar");
                Console.WriteLine("3-Excluir");
                Console.WriteLine("4-Listar");
                Console.WriteLine("5-Pesquisar");
                Console.WriteLine("9-Sair");
                Console.Write("Qual sua opção: ");
                string opc = Console.ReadLine();


                switch (opc)
                {
                  
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Incluir");
                        listaDados.Add(incluir());
                        break;
                    case "2":Console.WriteLine("Alterar");
                        Console.Write("Digite o ID do filme que deseja alterar: ");
                        string alterar = Console.ReadLine();
                        Console.Write("Digite seu novo ID: ");
                       Dados modificar = listaDados.Find(x => x.Id == alterar);
                        modificar.Id = Console.ReadLine();
                        Console.Write("Digite seu novo nome: ");
                        Dados modificar1 = listaDados.Find(x => x.Nome == alterar);
                        modificar.Nome = Console.ReadLine();
                        Console.Write("Digite seu novo genero: ");
                       Dados modificar2 = listaDados.Find(x => x.Genero == alterar);
                        modificar.Genero = Console.ReadLine();

                        
                        break;
                    case "3":Console.WriteLine("Excluir");
                        Console.WriteLine("Qual ID: ");
                         string Guardar = Console.ReadLine();
                        listaDados.Remove(listaDados.Find(x => x.Id == Guardar));
                        break;
                    case "4":Console.WriteLine("Listar");
                        listar();
                        break;
                    case "5":Console.WriteLine("Pesquisar");
                        Console.WriteLine("Qual nome do filme: ");
                        string pesquisar = Console.ReadLine();
                       Dados aux =  listaDados.Find(x => x.Nome == pesquisar);
                        Console.Write("Aqui esta sua pesquisa corno: " + aux);
                        break;
                    case "9":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida!!!");
                        break;
                }
            } while (continuar);
        } 

        private static Dados incluir()
        {
            Dados dados = new Dados();
            Console.Write("ID:");
            dados.Id = Console.ReadLine();
            Console.Write("Genero:");
            dados.Genero = Console.ReadLine();
            Console.Write("Nome:");
            dados.Nome = Console.ReadLine();

            return dados;
        }

        private static void listar()
        {
            foreach(Dados dados in listaDados)
            {
                Console.WriteLine(dados);
            }
        }




    }
}

