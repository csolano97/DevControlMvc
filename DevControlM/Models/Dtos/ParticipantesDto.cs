using System.ComponentModel.DataAnnotations;

namespace DevControlM.Models.Dtos
{
    public class ParticipantesDto
    {
        [Required]

        public string Nombre { get; set; }
        [Required]

        public string Apellido { get; set; }
        [Required]

        public int Sexo { get; set; }
        [Required]

        public string Identificacion { get; set; }

        public string Telefono { get; set; }
        //[Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}