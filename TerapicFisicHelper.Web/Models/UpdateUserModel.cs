using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class UpdateUserModel
    {
        [Required(ErrorMessage = "Debe incluir el nombre del usuario")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nombre del usuario debe tener entre 3 a 50 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Debe incluir el apellido del usuario")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Apellido del usuario debe tener entre 3 a 50 caracteres")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Debe incluir la descripcion del usuario")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Descripcion del usuario debe tener entre 3 a 50 caracteres")]
        public string Description { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        [Required(ErrorMessage = "Debe incluir la direccion del usuario")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Direccion del usuario debe tener entre 3 a 255 caracteres")]
        public string Address { get; set; }
        [Required]
        public long Phone { get; set; }
        [Required]
        public int Age { get; set; }
        [Required(ErrorMessage = "Debe incluir el email del usuario")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Email del usuario debe tener entre 3 a 100 caracteres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe incluir el pais del usuario")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Pais del usuario debe tener entre 3 a 80 caracteres")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Debe incluir el genero del usuario")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Genero del usuario debe tener entre 3 a 20 caracteres")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Debe incluir el password del usuario")]
        [StringLength(8, ErrorMessage = "Password del usuario debe tener al menos 8 caracteres")]
        public string Password { get; set; }
    }
}
