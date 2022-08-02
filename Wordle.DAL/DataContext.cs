using Microsoft.EntityFrameworkCore;
using Wordle.Model;

namespace Wordle.DAL
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            if (IsMain())
            {
                optionsBuilder.UseSqlServer(Resource.testDbConStr);
            }
            else
            {
                optionsBuilder.UseSqlServer(Resource.testDbConStr9g);
            }
        }

        //Check if programm is running on vr/9g pc
        private bool IsMain()
        {
            if (File.Exists(@"C:\Users\r019cvr"))
            {
                return true;
            }
            return false;
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            //Primary key from Stat.cs --> PlayerId + GameId
            modelBuilder.Entity<DateWord>().HasKey(id => new { id.WordId, id.Date });
            modelBuilder.Entity<Stat>().HasKey(id => new { id.Id, id.PlayerId });
        }

        //Tables to build
        public virtual DbSet<Stat>? Stats { get; set; }
        public virtual DbSet<Game>? Games { get; set; }
        public virtual DbSet<Player>? Players { get; set; }
        public virtual DbSet<Word>? Words { get; set; }
        public virtual DbSet<DateWord>? DateWords { get; set; }
    }
}