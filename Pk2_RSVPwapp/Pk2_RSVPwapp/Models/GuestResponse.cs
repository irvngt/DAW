using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pk2_RSVPwapp.Models
{
    public class GuestResponse
    {

        [Required(ErrorMessage="por favor ingrese su nombre.")]
        public string Name { get; set;}
        [Required(ErrorMessage = "por favor ingrese su correo electronico.")]
        [RegularExpression(".+\\@.+\\..+",
           ErrorMessage = "Favor de ingresar una cuenta de correo valida")]
        public string Email { get; set;}
        [Required(ErrorMessage = "Por favor ingrese un numero telefonico")]
        public string Phone { get; set;}

         [Required(ErrorMessage = "Por favor espesifique si asitira o no")]
        public bool? WillAttend { get; set;}
    }
}