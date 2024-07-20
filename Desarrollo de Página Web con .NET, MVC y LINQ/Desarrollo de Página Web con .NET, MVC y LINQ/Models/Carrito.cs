using System.ComponentModel.DataAnnotations;
using TpFinalPNTCarrito.Helpers;
using System.Collections.Generic;

namespace TpFinalPNTCarrito.Models
{
    public class Carrito
    {
        [Key]
        public int idCarrito { get; set; }
       
        public Cliente cliente { get; set; }

        public Compra Compra { get; set; }

        public List<CarritoItem> carritoItems { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public bool activo { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public double subTotal { get; set; }

      


    }
}