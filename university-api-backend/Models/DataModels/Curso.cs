using System.ComponentModel.DataAnnotations;

namespace university_api_backend.Models.DataModels
{
    public enum NivelCurso
    {
        Basico,
        Intermedio,
        Avanzado
    }

    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;

        public string DescripcionLarga { get; set; } = string.Empty;

        public string PublicoObjetivo { get; set; } = string.Empty;

        public string Objetivos { get; set; } = string.Empty;

        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public NivelCurso Nivel { get; set; }
    }
}

