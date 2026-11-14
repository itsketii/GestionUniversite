namespace GestionUniversite.Models;

public class Utilisateur
{
    public int IdUtilisateur { get; set; }
    public string NomComplet { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public bool Actif { get; set; } = true;
}
