using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Controllers
{
    public class AutoraController : Controller
    {
        public IActionResult Autora()
        {
            var listaDeAutoras = new Autora("Letícia").Model1;
            return View(listaDeAutoras);
        }

        public string Welcome()
        {
            return "Boas vindas";
        }
    }
}
