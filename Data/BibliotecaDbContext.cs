using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Data
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options) { }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Autor).WithMany(a => a.Libros)
                .HasForeignKey(l => l.IdAutor).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Categoria).WithMany(c => c.Libros)
                .HasForeignKey(l => l.IdCategoria).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Usuario).WithMany(u => u.Prestamos)
                .HasForeignKey(p => p.IdUsuario).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Libro).WithMany()
                .HasForeignKey(p => p.IdLibro).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
