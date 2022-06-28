using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController : Controller
    {
        private LivroRepositorioCSV _repo = new LivroRepositorioCSV();

        public IActionResult ParaLer()
        {
            ViewBag.Livros = _repo.ParaLer.Livros;
            return View("lista");
        }

        public IActionResult Lendo()
        {
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
        }

        public string Detalhes(int id)
        {
            var livro = _repo.Todos.FirstOrDefault(l => l.Id == id);
            return livro.Detalhes();
        }

        public string Teste()
        {
            return "nova funcionalidade foi implementada!";
        }
    }
}