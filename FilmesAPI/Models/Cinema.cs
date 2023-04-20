using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required (ErrorMessage = "The field nome is mandatory.")]
        public string Nome { get; set; }
    }
}
