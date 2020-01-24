using ExemploCursoEF.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCursoEF.DAL.Mappings
{
    public class ClienteMapConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapConfiguration()
        {
            this.ToTable("Clientes");

            this.HasKey(p => p.Id);

            this.Property(prop => prop.Nome).HasMaxLength(200).IsRequired().IsUnicode(false);
            this.Property(p => p.DataNascimento).HasColumnName("Data");
        }
    }
}
