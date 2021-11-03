using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class CreateSpecialistModel
    {
        [Required(ErrorMessage = "Debe asignar un usuario al especialista")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Debe incluir el especialidad de la sesion")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nombre de la especialidad debe tener entre 3 a 50 caracteres")]
        public string Specialty { get; set; }
    }
}
