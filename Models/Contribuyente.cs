using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace ProyectoParcial.Models
{
    public class Contribuyente
    {
        public string CondIVA { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public List<string> SelectedCondVenta { get; set; }
       
        public Contribuyente() {

            CondVenta = GetCondVenta();
        }

        public Contribuyente(int id, string condIVA, string cuit, string razonSocial, string domicilio, string email, List<string> selectedCondVenta, IEnumerable<SelectListItem> condVenta)
        {
            CondIVA = condIVA;
            Cuit = cuit;
            RazonSocial = razonSocial;
            Domicilio = domicilio;
            Email = email;
            SelectedCondVenta = selectedCondVenta;
            CondVenta = condVenta;
        }

        public Contribuyente(Contribuyente contribuyente)
        {
            CondIVA = contribuyente.CondIVA;
            Cuit = contribuyente.Cuit;
            RazonSocial = contribuyente.RazonSocial;
            Domicilio = contribuyente.Domicilio;
            Email = contribuyente.Email;
            SelectedCondVenta = contribuyente.SelectedCondVenta;
        }

        // Condicion de Venta
        public IEnumerable<SelectListItem> CondVenta { get; set; }
        public List<SelectListItem> GetCondVenta()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "Contado", Value = "Contado" });
            list.Add(new SelectListItem { Text = "Cheque", Value = "Cheque" });
            list.Add(new SelectListItem { Text = "Ticket", Value = "Ticket" });
            list.Add(new SelectListItem { Text = "Otra", Value = "Otra" });

            return list;
        }

    }
}
