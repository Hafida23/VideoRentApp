using Microsoft.AspNetCore.Mvc;
using VideoRentApp.Models;
using VideoRentApp.Repos;

namespace VideoRentApp.Controllers
{
	public class RenterController : Controller
	{
		private readonly RenterRepository _renterRepository;
		public RenterController(RenterRepository renterRepository)
		{
			_renterRepository = renterRepository;
		}

		public IActionResult Index()
		{
			var renters = _renterRepository.GetList();
			return View(renters);
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Renter renter)
		{
			_renterRepository.Create(renter);
			return RedirectToAction(nameof(Index));
		}
		[HttpGet]
		public IActionResult Update(int id)
		{
			var renter = _renterRepository.GetById(id);
			return View(renter);
		}
		[HttpPost]
		public IActionResult Update(Renter renter)
		{
			_renterRepository.Update(renter);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id)
		{
			var result = _renterRepository.GetById(id);
			return View(result);
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var renter = _renterRepository.GetById(id);
			return View(renter);
		}

		[HttpPost]
		public IActionResult Delete(Renter renter)
		{
			_renterRepository.Delete(renter);
			return RedirectToAction(nameof(Index));
		}
	}
}
