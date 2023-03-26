using Microsoft.AspNetCore.Mvc;
using RestaurantAPPwithMVC.Abstraction;
using RestaurantAPPwithMVC.Models;
using System.Diagnostics;

namespace RestaurantAPPwithMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRestaurant _restaurant;

        public HomeController(ILogger<HomeController> logger, IRestaurant restaurant)
        {
            _logger = logger;
            _restaurant=restaurant;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListRestaurant()
        {
            var model=_restaurant.GetListRestaurant();
            return View(model);
        }

        public ActionResult Details(Guid Id)
        {
            var model = _restaurant.GetRestaurant(Id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            restaurant.Id = Guid.NewGuid();
            var res = _restaurant.AddRestaurant(restaurant);
            ViewBag.Message = "Created Seccessfully";
            if(!res)
                ViewBag.Message = "Error in Create";
            return View();
        }
        [HttpGet]
        public ActionResult Update(Guid id)
        {
            var res = _restaurant.GetRestaurant(id);
            return View(res);
        }

        [HttpPost]
        public ActionResult Update(Restaurant restaurant)
        {
            var res = _restaurant.UpdateRestaurant(restaurant);
            ViewBag.Message = "Update Seccessfully";
            if (!res)
                ViewBag.Message = "Error in Update";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}