using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevControlM.Models
{
    public class Establecimientos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public int Nivel { get; set; }
        public int Institucion { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Mod { get; set; }


    }
}
