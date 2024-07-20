using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TpFinalPNTCarrito.Helpers
{
    public static class ErrorMsgs
    {
        public const string Requerido = "El campo {0} es requerido";

        public const string StrMaxMin = "{0} debe estar comprendido entre {2} y {1}";

        public const string StrSoloAlfab = "Solo se admiten caracteres alfabeticos";

        public const string Range = "{0} debe estar entre {1} y {2}";
    }
}