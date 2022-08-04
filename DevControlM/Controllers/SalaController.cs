using DevControlM.Data;
using DevControlM.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevControlM.Controllers
{
    public class SalaController : Controller
    {
        private readonly IDataAccess _data;

        public SalaController(IDataAccess data)
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
        public async Task<IActionResult> Crear (SalaDto sala)
        {
            if(ModelState.IsValid)
            {
                _data.CrearSala(sala);

                return RedirectToAction(nameof(Index));

            }


            return View();
        }

    }
}
