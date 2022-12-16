using Microsoft.AspNetCore.Mvc;

namespace EncuestasAPI.Controllers
{

    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
