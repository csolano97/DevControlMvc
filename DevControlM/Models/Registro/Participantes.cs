using System;

namespace DevControlM.Models.Registro
{


    public class TbParticipantes
    {
        public int Id {get;set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sexo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Guid QR {get;set;}
    }


}