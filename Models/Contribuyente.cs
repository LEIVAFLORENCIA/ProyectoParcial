using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace ProyectoParcial.Models
{
    public class Contribuyente
    {
        [Required]
        public string CondIVA { get; set; }
        [Required]
        public int Cuit { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Required][EmailAddress] 
        public string Email { get; set; }
        [Required]
        public List<string> SelectedCondVenta { get; set; }
       
        public Contribuyente() {

            CondVenta = GetCondVenta();
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
            list.Add(new SelectListItem { Text = "Contado", Value = "1" });
            list.Add(new SelectListItem { Text = "Cheque", Value = "2" });
            list.Add(new SelectListItem { Text = "Ticket", Value = "3" });
            list.Add(new SelectListItem { Text = "Otra", Value = "4" });

            return list;
        }

    }
}
