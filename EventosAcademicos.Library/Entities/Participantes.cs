using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAcademicos.Library.Entities
{
    public class Participantes
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Nombre { get; set; }


        [Display(Name = "Afiliacion Institucional")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string AfiliacionInstitucional { get; set; }


        [Display(Name = "Area de Interes")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string AreaInteres { get; set; }


        [Display(Name = "Tipo de Particiapacion..0")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string TipoParticipacion { get; set; }
    }
}
