using ClientManagement.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClientManagement.Controllers
{
    public class ConsultaController : Controller
    {
        
        private readonly DbContextConfig _ConsultaDB;
        private ConsultaController(DbContextConfig ConsultaDB) {
            _ConsultaDB = ConsultaDB;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
