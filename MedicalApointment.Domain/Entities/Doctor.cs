
using MedicalApointments.Domain.Base;

namespace MedicalApointments.Domain.Entities
{
    public class Doctor : BaseEntity
    {
        public int IdDoctor { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

    }
}
