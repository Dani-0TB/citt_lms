using System.ComponentModel.DataAnnotations;

namespace citt_lms.Models.Domain;

public class Persona
{
    public Guid Id { get; set; }
    
    [Required, MaxLength(30)]
    public string PrimerNombre { get; set; }
    
    [MaxLength(30)]
    public string SegundoNombre { get; set; }

    [Required, MaxLength(30)]
    public string ApellidoPaterno { get; set; }

    [MaxLength(30)]
    public string ApellidoMaterno { get; set; }

    [Required]
    public DateTime FechaIngreso { get; set; }

}