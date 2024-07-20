using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Key]
        public int idUsuario { get; set; }

        public Carrito carrito { get; set; }

        public List<Compra> compra { get; set; }

        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMaxMin)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrorMsgs.StrSoloAlfab)]
        public string nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public string apellido { get; set; }

        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(apellido) && string.IsNullOrEmpty(nombre)) return "Sin definir";
                if (string.IsNullOrEmpty(apellido)) return nombre;
                if (string.IsNullOrEmpty(apellido)) return apellido.ToUpper();

                return $"{apellido.ToUpper()}, {nombre}";
            }
        }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Range(1000000,99999999,ErrorMessage = ErrorMsgs.Range)]
        [Display(Name = Alias.PersonaDocumento)]
        public int dni { get; set; }

        [Required]
        [Phone]
        public int telefono { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public string direccion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public DateTime fechaAlta { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = Alias.CorreoElectronico)]
        public string email { get; set; }

        public Cliente(int idCliente, int idUsuario, string nombre, string apellido, int dni, int telefono, string direccion, string email)
        {
            this.idCliente = idCliente;
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fechaAlta = DateTime.Now;
            this.email = email;
            this.carrito = new Carrito();
            this.compra = new List<Compra>();
        }
    }
}