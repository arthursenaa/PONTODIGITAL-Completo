using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace PONTODIGITAL.Controllers
{
    public class ProdutoController : Controller
    {
        [HttpGet]
        public IActionResult Produto()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Solução()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Somos()
        {
            return View();
        }
    }
}