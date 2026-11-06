namespace GestionUniversite.Models;

public class Absence
{
    public int IdAbsence { get; set; }
    public bool Justifiee { get; set; }
    public string Motif { get; set; }
    public DateTime DateSaisie { get; set; }
    public int IdSeance { get; set; }
    public int IdEtudiant { get; set; }
}
