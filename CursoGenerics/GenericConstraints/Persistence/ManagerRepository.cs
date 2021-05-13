using CursoGenerics.GenericConstraints.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGenerics.GenericConstraints.Persistence
{
    public class ManagerRepository : DbContext
    {
        public ManagerRepository() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("repo");
        }
        DbSet<Manager> Managers { get; set; }
    }
}
