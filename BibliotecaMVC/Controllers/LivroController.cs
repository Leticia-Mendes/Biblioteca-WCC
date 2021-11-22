using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMVC.Controllers
{
    public class LivroController : Controller
    {
        List<Livro> listaDeLivros = null;

        public IActionResult Livro(string textoPesquisa)
        {
            listaDeLivros = new Livro().GetLivros(textoPesquisa);
            return View(listaDeLivros);
        }

        public IActionResult LivroDetail(int id)
        {
            var livro = new Livro().GetLivroPeloId(id);
            return View(livro);
        }
    }
}
