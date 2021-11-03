using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Entities
{
    public class Equipament
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Debe incluir el nombre del equipamiento")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nombre del equipamiento debe tener entre 3 a 50 caracteres")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Todo equipamiento debe tener una descripción")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Descripcion del cliente debe tener entre 3 a 255 caracteres")]
        public string Description { get; set; }
        
        public ICollection<EquipamentSession> EquipamentSessions { get; set; }
    }
}
