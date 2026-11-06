namespace GestionUniversite.Models;

public class AnneeAcademique
{
    public int IdAnnee { get; set; }
    public string Libelle { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public bool EstActive { get; set; }
}
