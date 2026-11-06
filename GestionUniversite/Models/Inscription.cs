namespace GestionUniversite.Models;

public class Inscription
{
    public int IdInscription { get; set; }
    public DateTime DateInscription { get; set; }
    public string Statut { get; set; }
    public decimal FraisInscription { get; set; }
    public int IdEtudiant { get; set; }
    public int IdClasse { get; set; }
    public int IdAnnee { get; set; }
}
