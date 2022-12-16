using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    public class EncuestaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
