using Microsoft.AspNetCore.Mvc.Rendering;

namespace MisCosas.Models
{
    public class CuentaCreacionViewModel : Cuenta
    {
        public IEnumerable<SelectListItem> TiposCuentas { get; set; }
    }
}
