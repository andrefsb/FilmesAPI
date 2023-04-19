using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "The movie title is mandatory!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "The movie genre is mandatory!")]
        [StringLength(50, ErrorMessage = "The movie genre mustn't have more then 50 caracters!")]

        public string Genero { get; set; }

        [Required(ErrorMessage = "The movie duration is mandatory!")]
        [Range(70, 600, ErrorMessage = "The movie duration must be between 70 and 600 minutes!")]
        public int Duracao { get; set; }
    }
}
