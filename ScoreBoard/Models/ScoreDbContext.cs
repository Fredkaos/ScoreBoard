using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class ScoreDbContext : DbContext
    {
        public ScoreDbContext(DbContextOptions<ScoreDbContext> options) : base(options)
        {

        }
        public DbSet<Jeu> Jeu { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
    }
}
