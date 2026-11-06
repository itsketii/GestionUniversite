namespace GestionUniversite.Models;

public class Cours
{
    public int IdCours { get; set; }
    public int VolumeHoraire { get; set; }
    public int IdClasse { get; set; }
    public int IdMatiere { get; set; }
    public int IdEnseignant { get; set; }
}
