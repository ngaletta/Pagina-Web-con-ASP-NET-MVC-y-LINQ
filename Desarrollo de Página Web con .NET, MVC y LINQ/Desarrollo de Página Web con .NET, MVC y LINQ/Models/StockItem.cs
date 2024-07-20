using System.ComponentModel.DataAnnotations;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class StockItem
    {
        [Key]
        public int idSucursal;
        [Key]
        public int idProducto;
        public Sucursal Sucursal { get; set; }

        public Producto Producto { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]

        public int cantidad;

        public StockItem(int sucursal, int producto, int cantidad)
        {
            this.idSucursal = sucursal;
            this.idProducto = producto;
            this.cantidad = cantidad;
        }
    }
}