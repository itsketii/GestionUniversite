namespace GestionUniversite.Models;

public class Etudiant
{
    public int IdEtudiant { get; set; }
    public string Matricule { get; set; }
    public string Nom { get; set; }
    public string Prenoms { get; set; }
    public DateTime DateNaissance { get; set; }
    public string LieuNaissance { get; set; }
    public string Sexe { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Adresse { get; set; }

    public string NomComplet => $"{Nom} {Prenoms}";
}
