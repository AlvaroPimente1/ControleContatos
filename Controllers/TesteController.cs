using Microsoft.AspNetCore.Mvc;

namespace ControleeContatos.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
