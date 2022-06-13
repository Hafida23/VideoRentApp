using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VideoRentApp.Models;
using VideoRentApp.Repos;

namespace VideoRentApp.Controllers
{
	public class MovieController : Controller
	{
		private readonly MovieRepository _movieRepository;
		public MovieController(MovieRepository movieRepository)
		{
			_movieRepository = movieRepository;
		}

		public IActionResult Index(int? id)
		{
			//var movies = _movieRepository.GetList();

			//if (id!=null)
			//{
			//	movies = movies.Where(i => i.RenterId == id).ToList();
			//}

			return View();
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Movie movie)
		{
			_movieRepository.Create(movie);
			return RedirectToAction(nameof(Index));
		}
		[HttpGet]
		public IActionResult Update(int id)
		{
			var movie = _movieRepository.GetById(id);
			return View(movie);
		}
		[HttpPost]
		public IActionResult Update(Movie movie)
		{
			_movieRepository.Update(movie);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id)
		{
			var result = _movieRepository.GetById(id);
			return View(result);
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var movie = _movieRepository.GetById(id);
			return View(movie);
		}

		[HttpPost]
		public IActionResult Delete(Movie movie)
		{
			_movieRepository.Delete(movie);
			return RedirectToAction(nameof(Index));
		}
	}
}
