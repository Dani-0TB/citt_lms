using System.ComponentModel.DataAnnotations;

namespace citt_lms.Models.Domain;

public class SeccionTaller
{
    public Guid Id { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public int cupos { get; set; }

}