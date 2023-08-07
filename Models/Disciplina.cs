using System.ComponentModel.DataAnnotations;

namespace IFROClasses.Models
{
    public class Disciplina : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string NomeDisciplina { get; set; }
    }
}
