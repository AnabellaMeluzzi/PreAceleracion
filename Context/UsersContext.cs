using Microsoft.EntityFrameworkCore;
using PrimeraEntrega.Entities;

namespace PrimeraEntrega.Context
{
    public class UsersContext: DbContext
    {
        public const string Schema = "users";
        public UsersContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
        }
        public DbSet<User> User { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
    
}
