using System;

namespace DevControlM.Models.Registro
{


    public class TbParticipantes
    {
        public int Id {get;set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sexo { get; set; }
        
        public string Identificacion {get;set;}
        public string Telefono { get; set; }

        public string Email { get; set; }
        public Guid QR {get;set;}
    }

    public class Sexo
    {
        public int Id { get; set; }
        public string sexo { get; set; }

        public Sexo(int Id, string sexo)
        {
            this.Id = Id;

            this.sexo = sexo;
        }

 
    }
}