using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JimmyAlbarracin_Examen1P.Models;

namespace JimmyAlbarracin_Examen1P.Controllers
{
    public class JA_Tabla1Controller : Controller
    {
        private readonly JimmyAlbarracin_DataContext _context;

        public JA_Tabla1Controller(JimmyAlbarracin_DataContext context)
        {
            _context = context;
        }

        // GET: JA_Tabla1
        public async Task<IActionResult> Index()
        {
            return View(await _context.JA_Tabla1.ToListAsync());
        }

        // GET: JA_Tabla1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jA_Tabla1 = await _context.JA_Tabla1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jA_Tabla1 == null)
            {
                return NotFound();
            }

            return View(jA_Tabla1);
        }

        // GET: JA_Tabla1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JA_Tabla1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,ContenidoPremium,Precio,Celular,FechaCompra")] JA_Tabla1 jA_Tabla1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jA_Tabla1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jA_Tabla1);
        }

        // GET: JA_Tabla1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jA_Tabla1 = await _context.JA_Tabla1.FindAsync(id);
            if (jA_Tabla1 == null)
            {
                return NotFound();
            }
            return View(jA_Tabla1);
        }

        // POST: JA_Tabla1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,ContenidoPremium,Precio,Celular,FechaCompra")] JA_Tabla1 jA_Tabla1)
        {
            if (id != jA_Tabla1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jA_Tabla1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JA_Tabla1Exists(jA_Tabla1.Id))
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
            return View(jA_Tabla1);
        }

        // GET: JA_Tabla1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jA_Tabla1 = await _context.JA_Tabla1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jA_Tabla1 == null)
            {
                return NotFound();
            }

            return View(jA_Tabla1);
        }

        // POST: JA_Tabla1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jA_Tabla1 = await _context.JA_Tabla1.FindAsync(id);
            if (jA_Tabla1 != null)
            {
                _context.JA_Tabla1.Remove(jA_Tabla1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JA_Tabla1Exists(int id)
        {
            return _context.JA_Tabla1.Any(e => e.Id == id);
        }
    }
}
