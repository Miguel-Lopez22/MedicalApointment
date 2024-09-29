
using MedicalApointments.Domain.Base;

namespace MedicalApointments.Domain.Entities
{
    public class Cita : BaseEntity
    {
        public int IdCita { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
    }
}
