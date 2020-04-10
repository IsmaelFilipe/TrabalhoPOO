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

                        cliente.ClienteExcel();

                        Console.WriteLine("Informe os dados do cliente");
                        string obj = Console.ReadLine();
                        
                        cliente.Remover(obj);
                        //List<Cliente> ListaDeCliente = excel.ClienteExcel();
                        //if (ListaDeCliente != null)
                        //{
                        //    Console.WriteLine("".PadRight(60, '-'));
                        //    Console.WriteLine("Codigo".PadRight(10) + "Nome".PadRight(35) + "Sexo".PadLeft(15));
                        //    Console.WriteLine("".PadRight(60, '-'));
                        //    foreach (var a in ListaDeCliente)
                        //    {
                        //        Console.WriteLine($"{a.codigo.PadRight(10)} |{a.Nome.PadRight(35)} |{a.Sexo.PadLeft(10)}");
                        //    }
                        //}
                        //else
                        //    Console.WriteLine("Item nao encontrado");
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
