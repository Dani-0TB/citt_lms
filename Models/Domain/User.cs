using System.ComponentModel.DataAnnotations;

namespace citt_lms.Models.Domain;

public class User 
{
    public Guid Id { get; set; }
    [StringLength(30)]
    public string Username { get; set; }
    [StringLength(30), MinLength(8)]
    public string Password { get; set; }
    public string Email { get; set; }
    public string PrimerNombre { get; set; }
    public string? SegundoNombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string? ApellidoMaterno { get; set; }
    public int SemestreCarrera { get; set; } = 1;
    public List<UserRole> Roles { get; set; }
    public int CarreraId { get; set; }
    public Carrera Carrera { get; set; }
}