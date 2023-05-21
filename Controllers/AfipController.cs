using Microsoft.AspNetCore.Mvc;
using ProyectoParcial.Models;

namespace ProyectoParcial.Controllers
{
    public class AfipController : Controller
    {
        /*
         * INTEGRANTES DEL PARCIAL:
         *  - Becco Fernandez, Santiago
         *  - Leiva, Florencia
         *  - Leiva. Pablo
        */
        public IActionResult Index()
        {
            var model = new Contribuyente();

            return View(model);
        }

        [HttpPost] public void HandleForm(Contribuyente newContribuyente)
        {
            if (ModelState.IsValid)
            {
                var listContribuyentes = new List<Contribuyente>();
                listContribuyentes.Add(newContribuyente);
            }

        }
    }
}
