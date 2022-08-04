using System;

namespace DevControlM.Models.Registro
{


    public class TbSala
    {
        public int Id {get;set;}
        
        public string Nombre { get; set; }
        public string Descripcion {get;set;}
        public string Lugar {get;set;}
        public DateTime FInicio   {get;set;}
        public DateTime F_Fin {get;set;}


    }


}