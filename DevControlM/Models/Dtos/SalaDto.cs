using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevControlM.Models.Dtos
{


    public class SalaDto
    {
        [Required]
        public string Nombre { get; set; }
        
        public string Descripcion {get;set;}
        [Required]
        public string Lugar {get;set;}
        [DisplayName("Fecha de inicio")]
        public DateTime FInicio   {get;set;}
        [DisplayName("Fecha de finalizacion")]

        public DateTime F_Fin {get;set;}


    }


}