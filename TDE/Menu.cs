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
            Excel excel = new Excel();
            
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
                            Mcliente = int.Parse(Console.ReadLine());
                            switch (Mcliente)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Informe os dados do cliente que deseja alterar");
                                    obj = Console.ReadLine();
                                    cliente.Alterar(obj);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Informe os dados do cliente que deseja remober");
                                    obj = Console.ReadLine();
                                    cliente.Remover(obj);
                                    break;
                            }
                        }
                       
                        break;
                    case 2:
                        Console.Clear();
                        //excel.Dependentes();
                        break;
                }
            }
        }
    }
}
