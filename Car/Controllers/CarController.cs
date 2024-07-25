using Car.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Model(string model, string year , string color)
        {
            var MyCar = new CarModel()
            {
                Model = string.IsNullOrEmpty(model) ? "N/A" : model,
                Year = year,
                Color = color
            };
            return View(MyCar);
        }
    }

}
