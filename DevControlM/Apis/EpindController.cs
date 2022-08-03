using DevControlM.Data;
using DevControlM.Models.Models_Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevControlM.Apis
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EpindController : ControllerBase
    {
        private readonly IConfiguration iconfiguration;
        private readonly IDataAccess _data;

        public EpindController(IConfiguration configuration, IDataAccess dataAccess)
        {
            iconfiguration = configuration;
            this._data = dataAccess;
        }

        [HttpGet]
        public ActionResult GetNot(int anio, int sem)
        {


            string sql = $"SELECT  ideig ,idt,estable,fechacon,semana,anio,expe,arst,ars,nss,idp,dui,nombres,apellidos,responsable,fecnac,sexo,edad,edadp,edadt,neducativo,direccion,idadm1,idadm2,idadm3,idadm4,idadm5,dpda,area,pais,latitud,longitud,telefono,embarazada,semanam,gestacion,fech_parto,tipo_parto,ocupacion,gocupacional,aocupacional,colectivo,nomcole,reciboat,manejo,comninguna,comdifres,cominshep,cominsren,comshohip,comsepticemia,comdesconocida,enfe,id_sitio_primario,id_tipo_histologico,diagnostico,fecinis,anioi,semanai,fecerupcion,signos,codesnutri,cobesidad,codiabetes,cofalcemia,corespira,cohiper,cosida,cotubercu,coninguna,codesconocida,coinmuno,cootra,cooespecifique,muestra,fectomam,antibiotera,fecantibio,personan,percargo,pertel,condicion,cgravedad,folio,fecfalle,fdeteccion,fecnoti,labstatusfinal,labstatus,labstatus2,labstatus3,lab,idef,fechaidef,usuario,ip FROM epind where anio={anio} and semana between 1 and {sem}";

            //+ anio + "and semana<=" + sem;


            var people = _data.LoadData<Pruebas, dynamic>(sql, new { }, iconfiguration.GetConnectionString("DataSof"));


            return Ok(people);
        }


        [HttpGet]
        public ActionResult GetPruebas(int anio, int sem)
        {


            string sql = $"SELECT idpr,idex,estable,fechacon,semana,anio,expe,arst,dui,nombres,apellidos,responsable,sexo,edad,edadp,direccion,ars,nss,area,enfe,fecinis,estatoma,tmuestra,ttipo,fectoma,fectenvio,estalab,idmue,feclabp,feclabe,resultadofinal,resultado,agente,subt,estatoma2,tmuestra2,ttipo2,fectoma2,fectenvio2,estalab2,idmue2,feclabp2,feclabe2,resultado2,agente2,subt2,estatoma3,tmuestra3,ttipo3,fectoma3,fectenvio3,estalab3,idmue3,feclabp3,feclabe3,resultado3,agente3,subt3,coinfeccion,agentecoinf,fecreg,usuario,ip FROM pruebas  where anio={anio} and semana between 1 and {sem}";

            //+ anio + "and semana<=" + sem;


            var people = _data.LoadData<Epind, dynamic>(sql, new { }, iconfiguration.GetConnectionString("DataSof"));


            return Ok(people);
        }

        [HttpGet]
        public ActionResult GetEstable(int anio, int sem)
        {


            string sql = $"SELECT  ideig ,idt,estable,fechacon,semana,anio,expe,arst,ars,nss,idp,dui,nombres,apellidos,responsable,fecnac,sexo,edad,edadp,edadt,neducativo,direccion,idadm1,idadm2,idadm3,idadm4,idadm5,dpda,area,pais,latitud,longitud,telefono,embarazada,semanam,gestacion,fech_parto,tipo_parto,ocupacion,gocupacional,aocupacional,colectivo,nomcole,reciboat,manejo,comninguna,comdifres,cominshep,cominsren,comshohip,comsepticemia,comdesconocida,enfe,id_sitio_primario,id_tipo_histologico,diagnostico,fecinis,anioi,semanai,fecerupcion,signos,codesnutri,cobesidad,codiabetes,cofalcemia,corespira,cohiper,cosida,cotubercu,coninguna,codesconocida,coinmuno,cootra,cooespecifique,muestra,fectomam,antibiotera,fecantibio,personan,percargo,pertel,condicion,cgravedad,folio,fecfalle,fdeteccion,fecnoti,labstatusfinal,labstatus,labstatus2,labstatus3,lab,idef,fechaidef,usuario,ip FROM epind where anio={anio} and semana between 1 and {sem}";

            //+ anio + "and semana<=" + sem;


            var people = _data.LoadData<Pruebas, dynamic>(sql, new { }, iconfiguration.GetConnectionString("DataSof"));


            return Ok(people);
        }
    }
}
