namespace citt_lms.Models.Domain;

public class Taller
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaTermino { get; set; }
}