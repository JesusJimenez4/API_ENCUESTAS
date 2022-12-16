using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    public class PreguntasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
