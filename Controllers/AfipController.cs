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

        public static List<Contribuyente> listContribuyentes = new List<Contribuyente>();

        public async Task<IActionResult> Index()
        {
            if(listContribuyentes.Count == 0)
            {
                var contribuyenteDefault = new Contribuyente
                {
                    CondIVA = "Exento",
                    Cuit = "27123456786",
                    RazonSocial = "Razon Social Test SRL",
                    Domicilio = "Calle falsa 123",
                    Email = "test@gmail.com",
                    SelectedCondVenta = new List<String>(new[] { "Contado", "Otra" })
                };
                listContribuyentes.Add(contribuyenteDefault);
            }

            return View(listContribuyentes);

        }

        [HttpPost] 
        public async Task<IActionResult> HandleForm(Contribuyente newContribuyente)
        {
            listContribuyentes.Add(newContribuyente);
            return RedirectToAction("Index");
        }

        public IActionResult CreateContribuyente()
        {
            var model = new Contribuyente();
            return View(model);
        }
    }
}
