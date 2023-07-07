using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Joueur
    {
        [Display(Name = "Numéro")]
        [Required(ErrorMessage = "Le numero est obligatoire")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        [RegularExpression(@"^[A-Za-z]{2,20}$", ErrorMessage = "Le champ doit contenir entre 2 et 20 caractères alphabétiques.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prenom est obligatoire")]
        [RegularExpression(@"^[A-Za-z]{2,20}$", ErrorMessage = "Le champ doit contenir entre 2 et 20 caractères alphabétiques.")]
        public string Prenom { get; set; }

        [RegularExpression("^[A-Z]{2,4}$", ErrorMessage = "Il doit y avoir 2 a 4 lettre majuscule")]
        public string? Equipe { get; set; }

        public string? Telephone { get; set; }

        [Required(ErrorMessage = "Le courriel est obligatoire")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@scoreboard\.ca$", ErrorMessage = "Le champ courriel doit être une adresse courriel valide de format Identifiant@scoreboard.ca.")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "Les jeux sont obligatoire")]
        public List<Jeu>? Jeux { get; set; }
    }
}
