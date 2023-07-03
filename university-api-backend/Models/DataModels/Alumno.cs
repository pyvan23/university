using System.ComponentModel.DataAnnotations;
namespace university_api_backend.Models.DataModels
{
    public class Alumno : BaseEntity
    {

        [Required]
        public string Nombre { get; set; }  = string.Empty;

        [Required]
        public string Apellido { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }

        public ICollection<Curso> cursos { get; set; } = new List<Curso>();
    }
}
