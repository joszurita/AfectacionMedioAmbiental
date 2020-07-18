using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioambiental.viewModels
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El \"Nombre\" es obligatorio")]

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        [Display(Name ="Su fotografia")]

        public IFormFile FotografiaPerfil { get; set; }
    }
}
