using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamo.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "obligado agregar un nombre.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "obligado agregar un número telefónico .")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "obligatodo agregar una dirección.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Es obligado agregar una fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public double Balance { get; set; }
    }
}
