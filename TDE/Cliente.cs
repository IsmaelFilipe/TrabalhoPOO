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
            Cliente cliente;

            var linha = 1;

            while (true)
            {
                cliente = new Cliente();
                cliente.codigo = planilhaCliente.Cell($"A{linha.ToString()}").Value.ToString();
                cliente.Nome = planilhaCliente.Cell($"B{linha.ToString()}").Value.ToString();
                cliente.Sexo = planilhaCliente.Cell($"C{linha.ToString()}").Value.ToString();

                if (string.IsNullOrEmpty(cliente.Nome)) break;

                linha++;
                Lclientes.Add(cliente);//adiciona a lista
            }            
        }

        public void Imprimir()
        {
            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("Codigo".PadRight(10) + "Nome".PadRight(35) + "Sexo".PadLeft(15));
            Console.WriteLine("".PadRight(60, '-'));
            foreach (Cliente x in Lclientes)
            {
                Console.WriteLine($"{x.codigo.PadRight(10)} |{x.Nome.PadRight(35)} |{x.Sexo.PadLeft(10)}");
            }
            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("");
            Console.ReadLine();
        }

        public void Remover(string ID)
        {


            Cliente cliente = Lclientes.Find(x => x.codigo == ID);
            if (cliente != null)
            {
                Lclientes.Remove(cliente);
            }
            Console.Clear();
            Console.WriteLine("Lista de Clientes atualizada");

            Imprimir();
        }

        public void Alterar(string ID)
        {

            Cliente cliente = Lclientes.Find(x => x.codigo == ID);
            if (cliente != null)
            {
                Console.WriteLine("Informe o novo nome");
                cliente.Nome = Console.ReadLine();
                Console.WriteLine("Informe o novo sexo");
                cliente.Sexo = Console.ReadLine();
            }
            else
                Console.WriteLine("Cliente nao encontrado!!");

            Console.Clear();
            Console.WriteLine("Lista de Clientes atualizada");
            Imprimir();
        }
    }
}
