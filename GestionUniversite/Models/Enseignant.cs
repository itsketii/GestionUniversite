namespace GestionUniversite.Models;

public class Enseignant
{
    public int IdEnseignant { get; set; }
    public string Matricule { get; set; }
    public string Nom { get; set; }
    public string Prenoms { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Grade { get; set; }
    public string Specialite { get; set; }
}
