using ClientManagement.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClientManagement.Controllers
{
    public class CadastroController : Controller
    {

        private readonly DbContextConfig _CadastroDB;
        private CadastroController(DbContextConfig CadastroDB) {
            _CadastroDB = CadastroDB;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
