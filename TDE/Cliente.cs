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

            var linha = 1;

            while (true)
            {
                Cliente cliente = new Cliente();
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
                Console.Clear();
                Console.WriteLine("Lista de Clientes atualizada");

                Imprimir();
            }
            else
            {
                Console.WriteLine("Cliente nao encontrado");
                Console.ReadLine();
            }
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
                Console.Clear();
                Console.WriteLine("Lista de Clientes atualizada");
                Imprimir();
            }
            else
            {
                Console.WriteLine("Cliente nao encontrado!!");
                Console.ReadLine();
            }
                
            
        }

        public void Pesquisa(string ID)
        {
            Cliente cliente = Lclientes.Find(x => x.codigo == ID);
            if (cliente != null)
                Console.WriteLine($"Codigo: {cliente.codigo}\nNome: {cliente.Nome}\nSexo: {cliente.Sexo}");
            else
                Console.WriteLine("Cliente nao encontrado!!");
        }
    }
}