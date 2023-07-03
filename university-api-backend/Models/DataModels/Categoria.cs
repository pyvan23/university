using System.ComponentModel.DataAnnotations;
namespace university_api_backend.Models.DataModels
{
    public class Categoria: BaseEntity
    {

        [Required]
        public string Nombre { get; set; } = string.Empty;

        public ICollection<Curso> Cursos { get; set; }   
    }
}
