using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE
{
    class Menu
    {
        public Menu()
        {
            Dependente dependente = new Dependente();
            dependente.DependenteExcel();

            Cliente cliente = new Cliente();
            cliente.ClienteExcel();

            int x = 1;
            while (x != 3)
            {
                Console.Clear();
                Console.WriteLine("".PadRight(50, '-'));

                Console.WriteLine("Menu:".PadRight(35));
                Console.WriteLine("1 - Cliente");
                Console.WriteLine("2 - Dependente");
                Console.WriteLine("3 - Sair");

                x = int.Parse(Console.ReadLine());
                Console.WriteLine("".PadRight(50, '-'));
                switch (x)
                {
                    case 1:
                        Console.Clear();
                        cliente.Imprimir();

                        int Mcliente = 0;

                        while (Mcliente != 5)
                        {
                            Console.Clear();
                            string obj;
                            Console.WriteLine("Menu cliente:");
                            Console.WriteLine("1 - Alterar dados");
                            Console.WriteLine("2 - Remover dados");
                            Console.WriteLine("3 - Pesquisar");
                            Console.WriteLine("4 - Sair");
                            Mcliente = int.Parse(Console.ReadLine());
                            switch (Mcliente)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Informe os codigo do cliente que deseja alterar");
                                    obj = Console.ReadLine();
                                    cliente.Alterar(obj);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Informe o codigo do cliente que deseja remover");
                                    obj = Console.ReadLine();
                                    cliente.Remover(obj);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Informe o codigo do cliente que deseja pesquisar");
                                    obj = Console.ReadLine();
                                    cliente.Pesquisa(obj);
                                    break;
                                default:
                                    Console.WriteLine("Opcao invalida");
                                    break;
                            }
                        }
                       
                        break;
                    case 2:
                        Console.Clear();
                        dependente.Imprimir();

                        int Mdependente = 0;

                        while (Mdependente != 4)
                        {
                            Console.Clear();
                            string obj;
                            Console.WriteLine("Menu dependente:");
                            Console.WriteLine("1 - Alterar dados");
                            Console.WriteLine("2 - Remover dados");
                            Console.WriteLine("3 - Pesquisar");
                            Mdependente = int.Parse(Console.ReadLine());
                            switch (Mdependente)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Informe o codigo do dependente que deseja alterar");
                                    obj = Console.ReadLine();
                                    dependente.Alterar(obj);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Informe o codigo do dependente que deseja remover");
                                    obj = Console.ReadLine();
                                    dependente.Remover(obj);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Informe o codigo do dependente que deseja pesquisar");
                                    obj = Console.ReadLine();
                                    cliente.Pesquisa(obj);
                                    break;
                                default:
                                    Console.WriteLine("Opcao invalida");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
            }
        }
    }
}
