using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class Categoria
    {
        public Producto Producto { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public string nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public string descripcion { get; set; }

        public Categoria(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}