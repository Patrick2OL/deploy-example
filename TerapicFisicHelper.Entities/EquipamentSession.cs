using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Entities
{
    public class EquipamentSession
    {
        [Required(ErrorMessage = "Debe asignar una equipamiento")]
        public int EquipamentId { get; set; }

        [Required(ErrorMessage = "Debe asignar una sesion")]
        public int SessionId { get; set; }
        
        public virtual Equipament Equipament { get; set; }
        public virtual Session Session { get; set; }
    }
}
