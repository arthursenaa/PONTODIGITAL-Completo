using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PONTODIGITAL.Models;
using PONTODIGITAL.Repositorio;
using PONTODIGITAL.Repositorios;

namespace PONTODIGITAL.Controllers {
    public class FaqController : Controller {
        [HttpGet]
        public IActionResult Faq () {
            return View ();
        }

        // public IActionResult Faq (IFormCollection form) {

        //     Faq coment = new Faq ();
        //     coment.Comentario = form["coment"];

        //     FaqRepositorio.Inserir(coment);
        //     return View ("FAQ");
        // }
    }
}