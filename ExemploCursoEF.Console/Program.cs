using ExemploCursoEF.BLL;
using ExemploCursoEF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCursoEF.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            System.Console.WriteLine("Digite o Nome do Cliente:");
            c.Nome = System.Console.ReadLine();
            System.Console.WriteLine("Digite a data de nascimento(dd/mm/yyyy):");
            c.DataNascimento = DateTime.ParseExact(System.Console.ReadLine(), "dd/MM/yyyy", null);

            ClienteBLL bll = new ClienteBLL();
            bll.Criar(c);

            List<Cliente> clientes = bll.Buscar("Ni", new DateTime(2009, 09, 09));

            foreach (var item in clientes)
            {
                System.Console.WriteLine(item.Nome);
            }

            System.Console.ReadKey();
        }
    }
}
