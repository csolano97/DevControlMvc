using DevControlM.Data;
using DevControlM.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
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
