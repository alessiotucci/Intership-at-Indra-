using Microsoft.EntityFrameworkCore;
using NetflixClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixClone.Data
{
    public class NetflixCloneDbContext : DbContext
    {
        public DbSet<Utente> Utenti {  get; set; }
        public DbSet<Profilo> Profili { get; set; }
        public DbSet<Video> Videos { get; set; }

        /*Not sure if needed -----------------------*/

        public DbSet<Film> Films { get; set; }
        public DbSet<SerieTv> SerieTv { get; set; }
        public DbSet<Stagione> Stagioni { get; set; }

        public DbSet<Episodio> Episodi { get; set; }
        /*------------------------------------------*/
        public string ConnectionString { get; }

        public NetflixCloneDbContext()
        {
            ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=NetflixCloneDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
