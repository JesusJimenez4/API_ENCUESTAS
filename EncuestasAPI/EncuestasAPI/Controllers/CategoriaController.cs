using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
