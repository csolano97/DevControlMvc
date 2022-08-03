using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevControlM.Models;

namespace DevControlM.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipiosController :ControllerBase
    {
        private readonly DevControlContext _context;
        public MunicipiosController(DevControlContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public  ActionResult GetMunicipios(int id)
        {
            var municipio =  _context.Municipios.Where(x =>x.Prov_Cod==id).ToList();
            if (municipio == null)
            {
                return NotFound();
            }


            
            return Ok(municipio);
        }

    }
}