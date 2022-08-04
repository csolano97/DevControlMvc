using System;

namespace DevControlM.Models.Registro
{


    public class TbRegistro
    {
        public int Id {get;set;}
        
        public int IdParticipante { get; set; }
        public DateTime Entrada {get;set;}
        public DateTime? Salida { get; set; }

    }


}