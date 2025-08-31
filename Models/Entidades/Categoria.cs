using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaBiblioteca.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string Codigo { get; set; }

        public bool Estado { get; set; }

        // Relación 1:N con Libro
        public ICollection<Libro> Libros { get; set; }
    }
}
