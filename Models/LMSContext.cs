using citt_lms.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace citt_lms.Model;
public class LMSContext: DbContext 
{
    public LMSContext(DbContextOptions options): base(options) {}
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<UserRole>().HasKey(k => new {k.UserId, k.RoleId});
    }
}