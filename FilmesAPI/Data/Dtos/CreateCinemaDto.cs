using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "The field nome is mandatory.")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
    }
}
