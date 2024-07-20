using System.ComponentModel.DataAnnotations;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class Compra
    {
        [Key]
        public int idCompra { get; set; }

        [Key]
        public int idCliente { get; set; }

        [Key]
        public int idCarrito { get; set; }


        public Carrito Carrito { get; set; }
        public Cliente Cliente { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public double total { get; set; } 

        public Compra(int idCompra, int idCliente, int idCarrito, double total)
        {
            this.idCompra = idCompra;
            this.idCliente = idCliente;
            this.idCarrito = idCarrito;
            this.total = total;
        }
    }
}