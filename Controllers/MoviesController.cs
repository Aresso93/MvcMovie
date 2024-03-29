﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MvcMovieContext _context;

        public MoviesController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {

            //IQueryable<string> genreQuery = from m in _context.Movie
            //                                orderby m.Genre
            //                                select m.Genre;

            var movies = from m in _context.Movie
                         select m;

            var dtoMovies =
            from movie in _context.Movie
            join genre in _context.Genre on movie.GenreId equals genre.Id into newTable
            from subGenre in newTable.DefaultIfEmpty()
            select new MovieDTO
            (
                movie.Id,
                movie.Title,
                movie.ReleaseDate,
                movie.Price,
                movie.Rating,
                subGenre.MovieGenre ?? string.Empty
            );
            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    movies = movies.Where(s => s.Title!.Contains(searchString));
            //}

            var movieGenreVM = new MovieGenreViewModel
            {
                //Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                MovieRecords = await dtoMovies.ToListAsync()
            };

            return View(movieGenreVM);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }
            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);

            //var dtoMovie =
            //from mymovie in _context.Movie
            //join genre in _context.Genre on mymovie.GenreId equals genre.Id into newTable
            //from subGenre in newTable.DefaultIfEmpty()
            //select new MovieDTO
            //(
            //    mymovie.Id,
            //    mymovie.Title,
            //    mymovie.ReleaseDate,
            //    mymovie.Price,
            //    mymovie.Rating,
            //    subGenre.MovieGenre ?? string.Empty
            //);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            var genre = _context.Genre.ToList();
            ViewData["Genre"] = new SelectList(genre, "Id", "MovieGenre");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,GenreId,Price,Rating")] Movie movie)
        {
            var genre = _context.Genre.ToList();
            ViewData["Genre"] = new SelectList(genre, "Id", "MovieGenre");

            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var genre = _context.Genre.ToList();
            ViewData["Genre"] = new SelectList(genre, "Id", "MovieGenre");

            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,GenreId,Price,Rating")] Movie movie)
        {
            var genre = _context.Genre.ToList();
            ViewData["Genre"] = new SelectList(genre, "Id", "MovieGenre");

            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
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
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Movie == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }
            var movie = await _context.Movie.FindAsync(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
          return (_context.Movie?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
