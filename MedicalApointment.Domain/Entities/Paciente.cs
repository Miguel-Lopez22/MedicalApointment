
using MedicalApointments.Domain.Base;

namespace MedicalApointments.Domain.Entities
{
    public class Paciente : BaseEntity
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
    }
}
