using System.ComponentModel.DataAnnotations;


namespace university_api_backend.Models.DataModels
{
    public class BaseEntity
    {
        //serie de columnas que queremos
        [Required]
        [Key]
        public int Id { get; set; } 
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;

        public DateTime? updatedAt { get; set; } 
        public DateTime? deletedAt { get; set; }
        public string DeletedBy { get; set; } = string.Empty;    

        public bool IsDeleted { get; set; } = false;
    }
}
