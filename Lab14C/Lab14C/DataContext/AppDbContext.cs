using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14C
{
    internal class AppDbContext: DbContext
    {
        //Path donde se puede guardar la base de datos
        string DbPath = string.Empty;

        //Tabla de base de datos
        public DbSet<Asignament> Course { get; set; }

        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename = {DbPath}");
        }
    }
}
