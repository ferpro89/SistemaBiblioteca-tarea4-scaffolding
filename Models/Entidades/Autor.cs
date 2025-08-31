using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaBiblioteca.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(120, ErrorMessage = "Máximo 120 caracteres")]
        [Display(Name = "Nombre completo")]
        public string Nombre { get; set; }

        [StringLength(80, ErrorMessage = "Máximo 80 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [StringLength(80, ErrorMessage = "Máximo 80 caracteres")]
        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        // Relación con libros
        public List<Libro> Libros { get; set; }
    }
}
