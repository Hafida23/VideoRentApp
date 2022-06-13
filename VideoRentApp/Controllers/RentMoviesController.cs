using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VideoRentApp.Data;
using VideoRentApp.Models;

namespace VideoRentApp.Controllers
{
    public class RentMoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentMoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RentMovies
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RentMovies.Include(r => r.Movie).Include(r => r.Renter);
            ViewBag.Movie = _context.Movies;
            ViewBag.Renter = _context.Renters;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RentMovies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentMovie = await _context.RentMovies
                .Include(r => r.Movie)
                .Include(r => r.Renter)
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (rentMovie == null)
            {
                return NotFound();
            }

            return View(rentMovie);
        }

        // GET: RentMovies/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId");
            ViewData["RenterId"] = new SelectList(_context.Renters, "RenterId", "FirstName");
            return View();
        }

        // POST: RentMovies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentMovieId,MovieId,RenterId")] RentMovie rentMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentMovie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", rentMovie.MovieId);
            ViewData["RenterId"] = new SelectList(_context.Renters, "RenterId", "FirstName", rentMovie.RenterId);
            return View(rentMovie);
        }

        // GET: RentMovies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentMovie = await _context.RentMovies.FindAsync(id);
            if (rentMovie == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", rentMovie.MovieId);
            ViewData["RenterId"] = new SelectList(_context.Renters, "RenterId", "FirstName", rentMovie.RenterId);
            return View(rentMovie);
        }

        // POST: RentMovies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentMovieId,MovieId,RenterId")] RentMovie rentMovie)
        {
            if (id != rentMovie.MovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentMovieExists(rentMovie.MovieId))
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
            ViewData["MovieId"] = new SelectList(_context.Movies, "MovieId", "MovieId", rentMovie.MovieId);
            ViewData["RenterId"] = new SelectList(_context.Renters, "RenterId", "FirstName", rentMovie.RenterId);
            return View(rentMovie);
        }

        // GET: RentMovies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentMovie = await _context.RentMovies
                .Include(r => r.Movie)
                .Include(r => r.Renter)
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (rentMovie == null)
            {
                return NotFound();
            }

            return View(rentMovie);
        }

        // POST: RentMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentMovie = await _context.RentMovies.FindAsync(id);
            _context.RentMovies.Remove(rentMovie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentMovieExists(int id)
        {
            return _context.RentMovies.Any(e => e.MovieId == id);
        }
    }
}
