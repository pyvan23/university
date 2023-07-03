using System.ComponentModel.DataAnnotations;

namespace university_api_backend.Models.DataModels
{
    public class Capitulo: BaseEntity
    {
        [Required]
        public string List = string.Empty;

        [Required]
        public int CursoId { get; set; }

        public  Curso Cursos { get; set; } = new Curso();
    }
}
