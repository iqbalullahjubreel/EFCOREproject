using EFCOREproject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFCOREproject.Controllers
{
    public class PizzaController : Controller
    {

        private readonly ILogger<PizzaController> _logger;

        private readonly IPizzaService _pizzaService;
        public PizzaController(ILogger<PizzaController> logger, IPizzaService repository)
        {
            _logger = logger;
            _pizzaService = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPizza() 
        {
            return View();
        }

        [HttpPost] 

        public IActionResult AddPizza(PizzaRequestModel model) 
        {
            PIZZA pizz = _pizzaService.AddNewPizza(model);
            return RedirectToAction("GetAllPizza");

        }
        [HttpGet]

        [HttpGet]
        public IActionResult GetAPizza(int id)
        {
            PIZZA pizz = _pizzaService.GetPizza(id);
            return View(pizz);
        }

        public IActionResult GetAllPizza()
        {
            List<PIZZA> pizz = _pizzaService.GetAllPizza();
            return View(pizz);
        }
        [HttpGet]

        public IActionResult UpdatePizza(int id)
        {
            PIZZA pp = _pizzaService.GetPizza(id);
            return View(pp);
        }
        [HttpPost]

        public IActionResult UpdatePizza(PIZZA model)
        {
            PIZZA pp = _pizzaService.UpdatePizza(model);
            return RedirectToAction("GetAllPizza");
        }
        [HttpGet]

        public IActionResult DeletePizza(int id)
        {
            PIZZA pp = _pizzaService.GetPizza(id);
            return View();
        }
        [HttpPost, ActionName("DeletePizza")]
        public IActionResult RealDelete(int id)
        {
            _pizzaService.DeleteNewPizza(id);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
