using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TpFinalPNTCarrito.Helpers;

namespace TpFinalPNTCarrito.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Empleado Empleado { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMaxMin)]
        [RegularExpression(@"[a-zA-Z áéíóú]*", ErrorMessage = ErrorMsgs.StrSoloAlfab)]
        public string nombre { get; set;}

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [Display(Name = Alias.CorreoElectronico)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [DataType(DataType.DateTime)]
        public DateTime fechaAlta { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Requerido)]
        [DataType(DataType.Password)]
        public string password { get; set; }
        // testeo melo
   
        public Usuario(int id, string nombre, string email, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.fechaAlta = DateTime.Now;
            this.password = password;
        }
    }
}