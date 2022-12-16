using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{
    public class RespuestasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
