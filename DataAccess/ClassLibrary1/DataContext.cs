using Wordle.Models ;
using Microsoft.EntityFrameworkCore;

namespace Wordle.DAL
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\r019cvr\source\repos\SchoolProjects\WordleBlazor\DataAccess\ClassLibrary1\Database\WordleDB.mdf;Integrated Security=True");
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\r019cvr\source\repos\SchoolProjects\WordleBlazor\DataAccess\ClassLibrary1\Database\WordleDB.mdf;Integrated Security=True",b => b.MigrationsAssembly("Wordle.DAL" ));

        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            //Primary key from Stat.cs --> PlayerId + GameId
            modelBuilder.Entity<Stat>().HasKey( id => new { id.PlayerId, id.GameId });
        }

        //Tables to be built
        public virtual DbSet<Stat>? Stats { get; set; }
        public virtual DbSet<Game>? Games { get; set; }
        public virtual DbSet<Player>? Players { get; set; }
        public virtual DbSet<Word>? Words { get; set; }
    }
}