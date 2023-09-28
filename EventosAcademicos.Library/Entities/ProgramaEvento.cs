using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAcademicos.Library.Entities
{
    public class ProgramaEvento
    {
        public int Id { get; set; }

        [Display(Name = "Horarios")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")] 
        public string Horarios { get; set; }

        [Display(Name = "Sesiones")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Sesiones { get; set; }

        [Display(Name = "Horarios")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Ponentes { get; set; }

        [Display(Name = "Temas de la Sesion")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string TemasSesion {  get; set; }
    }
}
