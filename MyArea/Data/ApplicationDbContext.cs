using Microsoft.EntityFrameworkCore;

namespace MyArea.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; } // db tables
        public DbSet<BlogPost> BlogPosts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>()
                .HasOne<UserProfile>()
                .WithMany()
                .HasForeignKey(bp => bp.UserId);
        }
    }
}
