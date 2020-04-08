using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace TDE
{
    public class Excel
    {
        public void Dependentes()
        {
            var wb = new XLWorkbook(@"D:\Faculdade\POO\TDE\DadosClientesDependente_255-637182350251595851.xlsx");
            var planilhaDependente = wb.Worksheet(2);
            Dependente dependente = new Dependente();

            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("Codigo Cliente".PadRight(10) + "   Codigo Dependente".PadRight(35) + "Nome".PadLeft(1));
            Console.WriteLine("".PadRight(60, '-'));

            var linha = 2;
            //public List<Cliente> clientes = new List<Cliente>();

            while (true)
            {
                dependente.CodigoCliente = planilhaDependente.Cell($"A{linha.ToString()}").Value.ToString();
                dependente.CodigoDependente = planilhaDependente.Cell($"B{linha.ToString()}").Value.ToString();
                dependente.Nome = planilhaDependente.Cell($"C{linha.ToString()}").Value.ToString();


                if (string.IsNullOrEmpty(dependente.CodigoCliente)) break;

                Console.WriteLine($"{dependente.CodigoCliente.PadRight(16)} |{dependente.CodigoDependente.PadRight(28)} |{dependente.Nome.PadLeft(8)}");
                linha++;
            }

            Console.WriteLine("".PadRight(60, '-'));
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
