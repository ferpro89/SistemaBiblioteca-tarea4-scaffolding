using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaBiblioteca.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }

        [Required, StringLength(100)]
        public string Apellido { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        // Relación 1:N con Prestamo
        public ICollection<Prestamo> Prestamos { get; set; }
    }
}
