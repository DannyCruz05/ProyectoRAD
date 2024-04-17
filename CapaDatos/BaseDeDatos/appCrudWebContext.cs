using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using CapaDatos.Modelos;

namespace CapaDatos.BaseDeDatos
{
    public class appCrudWebContext : DbContext
    {

        public appCrudWebContext() : base("empresa")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
    }
}
