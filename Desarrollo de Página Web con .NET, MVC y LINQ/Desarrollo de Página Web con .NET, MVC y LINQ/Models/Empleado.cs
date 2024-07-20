using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class Empleado
    {
        [Key]
        public int idEmpleado { get; set; }

        [Key]
        public int idUsuario { get; set; }

        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMaxMin)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrorMsgs.StrSoloAlfab)]
        public string nombre { get; set; }
    
        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        public string apellido { get; set; }

        public string NombreCompleto { 
            get
            {
                if (string.IsNullOrEmpty(apellido) && string.IsNullOrEmpty(nombre)) return "Sin definir";
                if (string.IsNullOrEmpty(apellido)) return nombre;
                if (string.IsNullOrEmpty(apellido)) return apellido.ToUpper();

                return $"{apellido.ToUpper()}, {nombre}";
            }
        }
      
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

        public Empleado(int idEmpleado, int idUsuario, string nombre, string apellido, int telefono, string direccion, string email)
        {
            this.idEmpleado = idEmpleado;
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fechaAlta = DateTime.Now;
            this.email = email;
        }
    }

}