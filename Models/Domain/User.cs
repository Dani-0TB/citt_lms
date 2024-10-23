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
    public List<UserRole> Roles { get; set; }
}