
using MedicalApointments.Domain.Base;

namespace MedicalApointments.Domain.Entities
{
    public class Agenda : BaseEntity
    {
        List<Cita> citas;
        List<Horario> horarios;

    }
}
