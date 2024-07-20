using System.ComponentModel.DataAnnotations;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class CarritoItem
    {
        [Key]
        public int idCarritoItem { get; set; }

        [Key]
        public int idProducto { get; set; }

        public Producto Producto { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public double valorUnitario { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int cantidad { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public int subtotal { get; set; }

        public CarritoItem(int idCarritoItem, int idProducto, double valorUnitario, int cantidad)
        {
            this.idCarritoItem = idCarritoItem;
            this.idProducto = idProducto;
            this.valorUnitario = valorUnitario;
            this.cantidad = cantidad;
            this.subtotal = (int)(valorUnitario * cantidad);
        }
    }
}