using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AfectacionMedioambiental.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El \"Nombre\" es obligatorio")]
        [DisplayName("El Nombre")]
        public string Nombre { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Apellido { get; set; }
        public Celular Celular { get; set; }
        [Display(Name ="Su fotografia")]
        public byte [] FotografiaPerfil { get; set; }
        [NotMapped]
        public string FotografiaBase64 { get; set; }
    }
}
