using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using VideoRentApp.Models;
using VideoRentApp.Models.Grid;
using System.Linq.Dynamic;
using VideoRentApp.Repos;

namespace VideoRentApp.Controllers
{
    public class GridController : Controller
    {
        private readonly MovieRepository _movieRepository;


        public GridController(MovieRepository repo)
        {
            _movieRepository = repo;
        }

        public IActionResult ShowGrid()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoadData(GridSettings grid)
        {
            try
            {

                
                var movie = _movieRepository.GetList();
                //Sorting
                if (!(string.IsNullOrEmpty(grid.SortColumn) && string.IsNullOrEmpty(grid.SortOrder)))
                {
                    movie = movie.OrderBy(grid.SortColumn + " " + grid.SortOrder);
                }

                //Search
                if (!string.IsNullOrEmpty(grid.Search))
                {
                    movie = movie.Where(m => m.Title == grid.Search || m.Genre == grid.Search || m.MainActress == grid.Search || m.DateRelease.ToString() == grid.Search || m.Length.ToString() == grid.Search);
                }

                //total number of rows count 
                var list = movie.ToList();
                var recordsTotal = list.Count();
                //Pagination 
                var data = movie.Skip(grid.Start).Take(grid.Length).ToList();
                return Json(new { draw = grid.Draw, recordsFiltered = recordsTotal, recordsTotal, data = GenerateJson(data) });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string[][] GenerateJson(List<Movie> movie)
        {
            if (movie == null || !movie.Any())
            {
                return (from i in new List<Movie>()
                        select new string[]
                    {
                    }).ToArray();
            }

            
            var Res = (from i in movie
                       select new string[]
                {
                    i.MovieId.ToString(),
                    i.Title,
                    i.Genre,
                    i.MainActress,
                    i.Description,
                    i.Length.ToString(),
                     $"<a href=/movie/details?id={i.MovieId}><i class=\"far fa-eye\"></i></a>"


                }).ToArray();
            return Res;
        }
    }
}
