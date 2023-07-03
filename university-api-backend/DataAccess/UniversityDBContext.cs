using Microsoft.EntityFrameworkCore;
using university_api_backend.Models.DataModels;

namespace university_api_backend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        //constructor
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {
        }
        //va a crear las tablas dentro de nuestra bases de datos
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Alumno>? Alumnos { get; set; }

        public DbSet<Capitulo>? Capitulos { get; set; }
    }
}
