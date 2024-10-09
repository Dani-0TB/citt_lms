using citt_lms.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace citt_lms.Model;
public class LMSContext: DbContext 
{
    public LMSContext(DbContextOptions options): base(options) {}
    public DbSet<User> Users { get; set; }
}