using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Jeu
    {
        [Required(ErrorMessage = "Le numero est obligatoire")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "La date de sortie est obligatoire")]
        public DateTime DateSortie { get; set; }

        [Required(ErrorMessage = "Le description est obligatoire")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Le id du joueur est obligatoire")]
        public int JoueurId { get; set; }

        [Required(ErrorMessage = "Le joueur est obligatoire")]
        public Joueur Joueur { get; set; }

        [Required(ErrorMessage = "Le scored du joueur est obligatoire")]
        [Range(0, 100, ErrorMessage = "Le score doit être compris entre 0 et 100.")]
        public int ScoreJoueur { get; set; }

        [Required(ErrorMessage = "La date d'enregistrement est obligatoire")]
        public DateTime DateEnregistrement { get; set; }
    }
}
