using Microsoft.EntityFrameworkCore;
using Aditya_Tie.Models; // Assuming your "Tie" model is in the "Aditya_Tie.Models" namespace

namespace Aditya_Tie.Data
{
    public class TieContext : DbContext
    {
        public TieContext(DbContextOptions<TieContext> options)
            : base(options)
        {
        }

        public DbSet<Tie> Tie { get; set; } // DbSet for the "Tie" entity
    }
}
