using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loja.Data;
using Loja.Models;

namespace Loja.Controllers
{
    public class ProdutoCategoriasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutoCategoriasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProdutoCategorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.produto_categoria.ToListAsync());
        }

        // GET: ProdutoCategorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoCategoria = await _context.produto_categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoCategoria == null)
            {
                return NotFound();
            }

            return View(produtoCategoria);
        }

        // GET: ProdutoCategorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdutoCategorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fk_id_produto,Fk_id_categoria")] ProdutoCategoria produtoCategoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoCategoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoCategoria);
        }

        // GET: ProdutoCategorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoCategoria = await _context.produto_categoria.FindAsync(id);
            if (produtoCategoria == null)
            {
                return NotFound();
            }
            return View(produtoCategoria);
        }

        // POST: ProdutoCategorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fk_id_produto,Fk_id_categoria")] ProdutoCategoria produtoCategoria)
        {
            if (id != produtoCategoria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoCategoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoCategoriaExists(produtoCategoria.Id))
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
            return View(produtoCategoria);
        }

        // GET: ProdutoCategorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoCategoria = await _context.produto_categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoCategoria == null)
            {
                return NotFound();
            }

            return View(produtoCategoria);
        }

        // POST: ProdutoCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoCategoria = await _context.produto_categoria.FindAsync(id);
            if (produtoCategoria != null)
            {
                _context.produto_categoria.Remove(produtoCategoria);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoCategoriaExists(int id)
        {
            return _context.produto_categoria.Any(e => e.Id == id);
        }
    }
}
