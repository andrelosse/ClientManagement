using Microsoft.AspNetCore.Mvc;

namespace ClientManagement.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
