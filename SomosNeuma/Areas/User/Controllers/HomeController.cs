using Microsoft.AspNetCore.Mvc;
using Neuma.DataAccess.Data;
using Neuma.DataAccess.Repository;
using Neuma.DataAccess.Repository.IRepository;
using Neuma.Models;
using SomosNeuma.Models;
using System.Diagnostics;

namespace SomosNeuma.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<TopFeature> features = _unitOfWork.TopFeature.GetAll().ToList();

            if (features == null)
            {
                return View();
            }

            return View(features);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
