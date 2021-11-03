using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class CreateEquipamentSessionModel
    {
        [Required(ErrorMessage = "Debe asignar una equipamiento")]
        public int EquipamentId { get; set; }

        [Required(ErrorMessage = "Debe asignar una sesion")]
        public int SessionId { get; set; }
    }
}
