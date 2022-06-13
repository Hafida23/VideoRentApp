using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoRentApp.Models;
using VideoRentApp.Repos;

namespace VideoRentApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly MovieRepository _movieRepository;

		public HomeController(MovieRepository movieRepository)
		{
			_movieRepository = movieRepository;
		}

		public IActionResult Index()
		{
			var movies = _movieRepository.GetList();
			return View(movies);
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
	}
}
