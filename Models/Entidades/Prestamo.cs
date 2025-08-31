using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBiblioteca.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        [StringLength(20)]
        public string Estado { get; set; }

        // FK con Usuario
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        // FK con Libro
        public int IdLibro { get; set; }
        public Libro Libro { get; set; }
    }
}
