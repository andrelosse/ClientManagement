using Microsoft.AspNetCore.Mvc;

namespace ClientManagement.Controllers
{
    public class ConsultaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
