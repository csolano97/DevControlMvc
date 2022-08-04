using System.ComponentModel.DataAnnotations;

namespace DevControlM.Models.Dtos
{
    public class ParticipantesDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sexo { get; set; }
        public string Telefono { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}