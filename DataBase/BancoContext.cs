using Microsoft.EntityFrameworkCore;
using ProgramaRegistros.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaRegistros.DataBase
{
    class BancoContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProgramaRegistrosBanco;Trusted_Connection=True;");
        }
    }
}