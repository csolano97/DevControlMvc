using DevControlM.Data;
using DevControlM.Models.Registro;
using DevControlM.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevControlM.Controllers
{
    public class ParticipantesController : Controller
    {
        private readonly IDataAccess _data;

        public ParticipantesController(IDataAccess data)
        {
            _data = data;
        }

        public   IActionResult Index()
        {
            return View(  _data.GetTbParticipantes());
        }
        public IActionResult Crear ()
        {
            List<Sexo> Sex = new List<Sexo>();
            Sex.Add(new Sexo(1, "Masculino"));
            Sex.Add(new Sexo(2, "Femenino"));



            var sex_list = new SelectList(Sex, "Id","sexo");
        ViewData["DBsexo"] = sex_list;

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear (ParticipantesDto participantes)
        {
            if(ModelState.IsValid)
            {
                _data.CrearParticipantes(participantes);

                return RedirectToAction(nameof(Index));

            }


            return View();
        }

    }
}
