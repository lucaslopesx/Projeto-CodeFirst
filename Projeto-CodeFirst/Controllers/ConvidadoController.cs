using Microsoft.AspNetCore.Mvc;
using Projeto_CodeFirst.Models;

namespace Projeto_CodeFirst.Controllers
{
    public class ConvidadoController : Controller
    {
        private static IList<Convidado> listConvidados = new List<Convidado>()
        {
            new Convidado()
            {
                GuestId = 0,
                Email = "lucas.lopesx1@gmail.com",
                Name = "Lucas Lopes",
                Phone = "35999694467",
                presence = true
            }
        };

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Convidado convidado)
        {
            listConvidados.Add(convidado);
            convidado.GuestId = listConvidados.Select(m => m.GuestId).Max() + 1;
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(listConvidados.Where(x => x.GuestId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Convidado convidado)
        {
            listConvidados.Remove(listConvidados.Where(x => x.GuestId == convidado.GuestId).First());
            listConvidados.Add(convidado);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(listConvidados.Where(x => x.GuestId == id).First());
        }

        public IActionResult Delete(int id)
        {
            return View(listConvidados.Where(x => x.GuestId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Convidado convidado)
        {
            listConvidados.Remove(listConvidados.Where(x => x.GuestId == convidado.GuestId).First());
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(listConvidados);
        }
    }
}
