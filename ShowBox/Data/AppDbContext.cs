using Microsoft.EntityFrameworkCore;
using ShowBox.Models;

namespace ShowBox.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :  base(options)
        {
            
        }

        public DbSet<Serie> Series { get; set; }
        public DbSet<Review> Reviews { get; set; }

        #region On Model Creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Many To Many Relations

            // SerieReview
            modelBuilder.Entity<SerieReview>()
                .HasOne(x => x.Serie)
                .WithMany(x => x.SerieReviews)
                .HasForeignKey(x => x.SerieId);

            #endregion
        }

        #endregion
    }
}
