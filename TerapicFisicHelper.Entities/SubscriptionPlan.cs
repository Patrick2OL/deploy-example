using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Entities
{
    public class SubscriptionPlan
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Debe incluir el nombre del plan suscripcion")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nombre del plan de suscripcion debe tener entre 3 a 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe incluir la descripcion del Plan suscripcion")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Descripcion del plan suscripcion debe tener entre 3 a 255 caracteres")]
        public string Description { get; set; }
        
        [Required]
        public int Cost { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }

    }
}
