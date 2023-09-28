using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosAcademicos.Library.Entities
{
    public class EvenAcademicos
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del Evento")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string NombreEvento { get; set; }

        [Display(Name = "Fecha Inicio")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string FechaInicio { get; set; }

        [Display(Name = "Fecha Finalizacion")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string FechaFinalizacion { get; set; }

        [Display(Name = "Ubicacion")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Ubicacion { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Descripcion { get; set; }

        [Display(Name = "Tema de la Sesion")]
        [MaxLength(45, ErrorMessage = "El campo no debe tener mas de 45 caracteres")]
        public string Tema { get; set; }
    }
}
