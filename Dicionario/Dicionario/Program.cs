using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionario
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("| 1 | - Inserir\n| 2 | - Remover\n| 3 | - Buscar\n| 4 | - Size\n| 5 | - Print\n| 6 | - Sair");
        }
        static void Main(string[] args)
        {
            Dicionario hash = new Dicionario();
            int opcao;
            do
            {
                Menu();
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite a Chave que deseja inserir");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor que deseja inserir");
                    Object o = Console.ReadLine();
                    hash.insertItem(k, o);
                }

                if (opcao == 2)
                {
                    Console.WriteLine("Digite a Chave que deseja remover");
                    int k = int.Parse(Console.ReadLine());
                    hash.removeElement(k);
                }

                if (opcao == 3)
                {
                    Console.WriteLine("Digite a Chave que deseja buscar");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine(hash.findElement(k));
                }

                if (opcao == 4)
                {
                    Console.WriteLine(hash.size());
                }
                if (opcao == 5)
                {
                    hash.print();
                }

            } while (opcao != 6);
        }
    }
}
