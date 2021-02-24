using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamo.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required(ErrorMessage = "obligado introducir un concepto.")]
        public string Descripcion { get; set; }
        [Range(minimum: 100, maximum: 100000000)]
        public double Monto { get; set; }
        public double Balance { get; set; }
        [Required(ErrorMessage = "Debe seleccionar una persona para asignar el prestamo.")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Persona { get; set; }
    }
}
