using System.ComponentModel.DataAnnotations;

namespace IFROClasses.Models
{
    public class Professor : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string NomeProfessor { get; set; }
    }
}
