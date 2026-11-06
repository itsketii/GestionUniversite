namespace GestionUniversite.Models;

public class Seance
{
    public int IdSeance { get; set; }
    public DateTime DateSeance { get; set; }
    public TimeSpan HeureDebut { get; set; }
    public TimeSpan HeureFin { get; set; }
    public string TypeSeance { get; set; }
    public string Statut { get; set; }
    public int IdCours { get; set; }
    public int IdSalle { get; set; }
}
