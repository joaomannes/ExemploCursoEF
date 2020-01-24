using ExemploCursoEF.DAL;
using ExemploCursoEF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCursoEF.BLL
{
    public class ClienteBLL
    {

        public Cliente Criar(Cliente c)
        {
            using (ExemploEFCursoContext context = new ExemploEFCursoContext())
            {
                context.Clientes.Add(c);
                context.SaveChanges();
                return c;
            }

        }

        public List<Cliente> CriarVarios(List<Cliente> clientes)
        {
            using (ExemploEFCursoContext context = new ExemploEFCursoContext())
            {
                context.Database.Log = Console.Write;
                context.Clientes.AddRange(clientes);
                context.SaveChanges();
                return clientes;
            }
        }

        public Cliente Atualizar(Cliente c)
        {
            using (ExemploEFCursoContext context = new ExemploEFCursoContext())
            {
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return c;
            }
        }

        public void Excluir(Cliente c)
        {
            using (ExemploEFCursoContext context = new ExemploEFCursoContext())
            {
                context.Clientes.Remove(c);
                context.SaveChanges();
            }
        }

        public List<Cliente> BuscarTodos()
        {
            using (ExemploEFCursoContext context = new ExemploEFCursoContext())
            {
                return context.Clientes.ToList();
            }
        }

        public Cliente BuscarPorId(int id)
        {
            using (ExemploEFCursoContext context = new ExemploEFCursoContext())
            {
                return context.Clientes.Find(id);
            }
        }

        public List<Cliente> Buscar(string nome, DateTime data)
        {
            using (ExemploEFCursoContext context = new ExemploEFCursoContext())
            {
                context.Database.Log = Console.Write;
                return context.Clientes.Where(c => c.Nome.Contains(nome) && c.DataNascimento == data).ToList();
            }
        }
    }
}
