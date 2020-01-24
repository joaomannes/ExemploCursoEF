using ExemploCursoEF.DAL.Mappings;
using ExemploCursoEF.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCursoEF.DAL
{
    public class ExemploEFCursoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public ExemploEFCursoContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Configurations.Add(new ClienteMapConfiguration());
        }
    }
}
