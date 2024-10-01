using LaboBibliotheque.Configs;
using LaboBibliotheque.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboBibliotheque
{
    internal class DataContext : DbContext
    {
        public DbSet<Livres> Livres { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Achats> Achats { get; set; }
        public DbSet<Utilisateurs> Utilisateurs { get; set; }
        public DbSet<Adresses> Adresses{ get; set; }
        public DbSet<Ecrits> Ecrits { get; set; }
        public DbSet<Auteurs> Auteurs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LaboBibli;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
