using System.ComponentModel.DataAnnotations;

namespace IFROClasses.Models
{
    public class Horario : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Periodo { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public string DiaDaSemana { get; set; }

        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public int SalaId { get; set; }
        public Sala Sala { get; set; }
    }

}
