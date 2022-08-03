using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevControlM.Models;

namespace DevControlM.Controllers
{
    public class EstablecimientosController : Controller
    {
        private readonly DevControlContext _context;

        public EstablecimientosController(DevControlContext context)
        {
            _context = context;
        }

        // GET: Establecimientos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Establecimientos.ToListAsync());
        }

        // GET: Establecimientos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var establecimientos = await _context.Establecimientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (establecimientos == null)
            {
                return NotFound();
            }

            return View(establecimientos);
        }

        // GET: Establecimientos/Create
        public IActionResult Create()
        {
        var prov = _context.Provincias.ToList();
            var lista = new SelectList(prov, "Id", "Nombre");
            ViewData["DBProvincias"] = lista;

        var inst = _context.Institucion.ToList();
            var lista_inst = new SelectList(inst, "Id", "Institucion");
            ViewData["DBinstitucion"] = lista_inst;

            return View();
        }

        // POST: Establecimientos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Provincia,Municipio,Nivel,Institucion,Fecha_Mod")] Establecimientos establecimientos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(establecimientos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(establecimientos);
        }

        // GET: Establecimientos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var establecimientos = await _context.Establecimientos.FindAsync(id);
            if (establecimientos == null)
            {
                return NotFound();
            }
            return View(establecimientos);
        }

        // POST: Establecimientos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Provincia,Municipio,Nivel,Institucion,Fecha_Mod")] Establecimientos establecimientos)
        {
            if (id != establecimientos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(establecimientos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstablecimientosExists(establecimientos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(establecimientos);
        }

        // GET: Establecimientos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var establecimientos = await _context.Establecimientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (establecimientos == null)
            {
                return NotFound();
            }

            return View(establecimientos);
        }

        // POST: Establecimientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var establecimientos = await _context.Establecimientos.FindAsync(id);
            _context.Establecimientos.Remove(establecimientos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstablecimientosExists(int id)
        {
            return _context.Establecimientos.Any(e => e.Id == id);
        }
    }
}
