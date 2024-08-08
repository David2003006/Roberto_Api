

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIROBERTO.Models.DCModel
{
    public class Aspirante 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_aspirante { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string Correo {get; set; }

        public int Telefono { get; set; }

        public string Vacante  { get; set; }

        public string Disponibilidad { get; set; }

        public string Experiencia { get; set; }
    }
}