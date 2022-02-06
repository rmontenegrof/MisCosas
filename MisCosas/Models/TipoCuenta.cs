using Microsoft.AspNetCore.Mvc;
using MisCosas.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace MisCosas.Models
{
    public class TipoCuenta //:IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [Display(Name ="Nombre del tipo de cuenta")]
        [PrimeraLetraMayuscula]
     //   [Remote(action: "VerificarExisteTipoCuenta", controller: "TiposCuentas")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set;}
        public int Orden { get; set; }

        /*   public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
           {
               if(Nombre != null && Nombre.Length >0)
               {
                   var primeraLetra = Nombre[0].ToString();

                   if(primeraLetra != primeraLetra.ToUpper())
                   {
                       yield return new ValidationResult("La primera letra debe ser mayúscula",
                           new[] { nameof(Nombre) });
                   }
               }
           } */

        /* Pruebas de otras validaciones por defecto */

        /*  [Required(ErrorMessage = "El campo {0} es requerido")]
          [EmailAddress(ErrorMessage ="El email ingresado es inválido")]
          public string Email { get; set; }

          [Range(minimum: 18, maximum: 130, ErrorMessage = "La longitud del campo {0} debe estar entre {1} y {2}")]
          public int Edad { get; set; }

          [Url(ErrorMessage ="Debe ingresar una URL válida")]
          public string URL { get; set; }

          [CreditCard(ErrorMessage ="la tarjeta no es válida")]
          [Display(Name ="Tarjeta de Crédito")]
          public string TarjetaDeCredito { get; set; }*/
    }
}
