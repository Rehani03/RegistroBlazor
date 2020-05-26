using Microsoft.EntityFrameworkCore;
using RegistroBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroBlazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Notas> Notas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\HallazgosControl.db");
        }

    }
}
