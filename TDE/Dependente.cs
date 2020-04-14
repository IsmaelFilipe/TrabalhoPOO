using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE
{
    public class Dependente 
    {
        public string CodigoCliente { get; set; }
        public string CodigoDependente { get; set; }
        public string Nome { get; set; }

        List<Dependente> Ldependentes = new List<Dependente>();
        public void DependenteExcel()
        {
            var wb = new XLWorkbook(@"D:\Faculdade\POO\TDE\DadosClientesDependente.xlsx");
            var planilhaDependente = wb.Worksheet(2);
            Dependente dependente;

            var linha = 1;

            while (true)
            {
                dependente = new Dependente();
                dependente.CodigoCliente = planilhaDependente.Cell($"A{linha.ToString()}").Value.ToString();
                dependente.CodigoDependente = planilhaDependente.Cell($"B{linha.ToString()}").Value.ToString();
                dependente.Nome = planilhaDependente.Cell($"C{linha.ToString()}").Value.ToString();

                if (string.IsNullOrEmpty(dependente.Nome)) break;

                linha++;
                Ldependentes.Add(dependente);//adiciona a lista
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("".PadRight(60, '-'));
            foreach (Dependente x in Ldependentes)
            {
                Console.WriteLine($"{x.CodigoCliente.PadRight(10)} {x.CodigoDependente.PadRight(32)} {x.Nome.PadLeft(8)}");
            }
            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("");
            Console.ReadLine();
        }

        public void Remover(string ID)
        {


            Dependente dependente = Ldependentes.Find(x => x.CodigoDependente == ID);
            if (dependente != null)
            {
                Ldependentes.Remove(dependente);
            }
            Console.Clear();
            Console.WriteLine("Lista de Clientes atualizada");

            Imprimir();
        }

        public void Alterar(string ID)
        {

            Dependente dependente = Ldependentes.Find(x => x.CodigoDependente == ID);
            if (dependente != null)
            {
                Console.WriteLine("Informe o novo codigo de cliente");
                dependente.CodigoCliente = Console.ReadLine();
                Console.WriteLine("Informe o novo nome");
                dependente.Nome = Console.ReadLine();
            }
            else
                Console.WriteLine("Cliente nao encontrado!!");

            Console.Clear();
            Console.WriteLine("Lista de Clientes atualizada");
            Imprimir();
        }

        public void Pesquisa(string ID)
        {
            Dependente dependente = Ldependentes.Find(x => x.CodigoDependente == ID);
            if (dependente != null)
            {
                Console.WriteLine($"Codigo: {dependente.CodigoCliente}\nNome: {dependente.CodigoDependente}\nSexo: {dependente.Nome}");
            }
            else
                Console.WriteLine("Cliente nao encontrado!!");
            Console.ReadLine();
        }
    }
}
