public class Paciente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public Especies Especie { get; set; }

    
    public string ToCSV()
    {
        return $"{Id};{Nombre};{Edad};{Especie}";
    }
}