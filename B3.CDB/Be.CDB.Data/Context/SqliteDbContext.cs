using B3.CDB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Be.CDB.Data.Context
{
    public class SqliteDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=sqlite_cdb", option =>
            {
                option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Imposto>()
                .ToTable("Impostos", "teste")
                .HasData(new Imposto { Id = 1, AteQueMes = 6, Descricao = "CDB 1 Description", Percentual = 12 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
