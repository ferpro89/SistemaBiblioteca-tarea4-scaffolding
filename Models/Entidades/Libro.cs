using System.ComponentModel.DataAnnotations;

namespace SistemaBiblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Titulo { get; set; }

        [StringLength(20)]
        public string ISBN { get; set; }

        public int AñoPublicacion { get; set; }

        
        public int IdAutor { get; set; }
        public Autor Autor { get; set; }

       
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
