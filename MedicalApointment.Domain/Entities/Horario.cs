
using MedicalApointments.Domain.Base;

namespace MedicalApointments.Domain.Entities
{
    public class Horario : BaseEntity
    {
        public string Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
    }
}
