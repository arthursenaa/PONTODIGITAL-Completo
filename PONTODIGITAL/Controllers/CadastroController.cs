using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PONTODIGITAL.Models;
using PONTODIGITAL.Repositorio;

namespace PONTODIGITAL.Controllers {
    public class CadastroController : Controller {
        private ClienteRepositorio ClienteRepositorio = new ClienteRepositorio ();

        [HttpGet]
        public IActionResult Cadastrar(){

            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            Cadastro cliente = new Cadastro ();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.Senha = form["senha"];
            cliente.Telefone = form["tel"];
            cliente.DataNascimento = DateTime.Parse(form["data"]);
            // cliente.Foto = form["foto"];

            ClienteRepositorio.Inserir (cliente);
            return View ("Cadastrar");
        }
    }
}