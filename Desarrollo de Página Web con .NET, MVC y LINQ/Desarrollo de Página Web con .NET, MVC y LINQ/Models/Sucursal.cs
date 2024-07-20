using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class Sucursal
    {
        [Key]
        public int idSucursal { get; set; }

        public StockItem StockItem { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMaxMin)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrorMsgs.StrSoloAlfab)]
        public string nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public string direccion { get; set; }
        [Required]
        [Phone]
        public int telefono { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        public List<StockItem> stockItems { get; set; }

        public Sucursal(int idSucursal, string nombre, string direccion, int telefono, string email)
        {
            this.idSucursal = idSucursal;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.stockItems = new List<StockItem>();
        }
    }
}