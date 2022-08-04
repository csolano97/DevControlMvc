using DevControlM.Data;
using DevControlM.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevControlM.Controllers
{
    public class RegistroController : Controller
    {
        private readonly IDataAccess _data;

        public RegistroController(IDataAccess data)
        {
            _data = data;
        }

        public   IActionResult Index()
        {
            var lista_inst = new SelectList(_data.GetSalas(), "Id", "Nombre");
            ViewData["DbSalas"] = lista_inst;
            return View();
        }
  

    }
}
