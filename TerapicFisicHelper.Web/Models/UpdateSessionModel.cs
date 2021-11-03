using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class UpdateSessionModel
    {
        [Required(ErrorMessage = "Debe incluir el titulo de la sesion")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nombre del titulo debe tener entre 3 a 50 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Debe incluir la descripcion de la sesion")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nombre del descripcion debe tener entre 3 a 255 caracteres")]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public string StartHour { get; set; }

        [Required]
        public string EndHour { get; set; }
    }
}
