using citt_lms.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace citt_lms.Model;
public class LMSContext: DbContext 
{
    public LMSContext(DbContextOptions options): base(options) {}
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Carrera> Carreras { get; set; }
    public DbSet<Taller> Tallers { get; set; }
    public DbSet<Sesion> Sesiones { get; set;}
    public DbSet<SeccionTaller> SeccionesTaller { get; set; }
    public DbSet<SesionTaller> SesionesTaller { get; set; }
    public DbSet<Sala> Salas { get; set; }
    public DbSet<Persona> Personas {get; set;}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<UserRole>().HasKey(k => new {k.UserId, k.RoleId});
    }
}