using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE
{
    public class Cliente
    {
        public string codigo { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }

        public List<Cliente> Lclientes = new List<Cliente>();
        public void ClienteExcel()
        {
            var wb = new XLWorkbook(@"D:\Faculdade\POO\TDE\DadosClientesDependente.xlsx");
            var planilhaCliente = wb.Worksheet(1);
            Cliente cliente = new Cliente();


            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("Codigo".PadRight(10) + "Nome".PadRight(35) + "Sexo".PadLeft(15));
            Console.WriteLine("".PadRight(60, '-'));

            var linha = 2;

            while (true)
            {

                cliente.codigo = planilhaCliente.Cell($"A{linha.ToString()}").Value.ToString();
                cliente.Nome = planilhaCliente.Cell($"B{linha.ToString()}").Value.ToString();
                cliente.Sexo = planilhaCliente.Cell($"C{linha.ToString()}").Value.ToString();



                if (string.IsNullOrEmpty(cliente.Nome)) break;

                Console.WriteLine($"{cliente.codigo.PadRight(10)} |{cliente.Nome.PadRight(35)} |{cliente.Sexo.PadLeft(10)}");
                linha++;
                cliente.Lclientes.Add(cliente);//adiciona a lista
            }
            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("");
            Console.ReadLine();
            foreach (Cliente x in Lclientes)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }



        public void Remover(string ID)
        {
            

            Cliente cliente = Lclientes.Find(x => x.codigo == ID);
            if(cliente != null)
            {
                Lclientes.Remove(cliente);
            }

            Console.WriteLine("Lista de Clientes atualizada");

            foreach(Cliente x in Lclientes)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
