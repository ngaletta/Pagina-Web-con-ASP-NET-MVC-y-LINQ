using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class Producto
    {
        [Key]
        public int idCategoria { get; set; }

        public StockItem StockItem { get; set; }

        public Categoria Categoria { get; set; }

        public CarritoItem CarritoItem { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMaxMin)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrorMsgs.StrSoloAlfab)]
        public string nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public string descripcion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public double precioVigente { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public Boolean activo { get; set; }
    

        public Producto(string nombre, string descripcion, double precioVigente, bool activo, int idCategoria)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precioVigente = precioVigente;
            this.activo = activo;
            this.idCategoria = idCategoria;
        }
    }
}