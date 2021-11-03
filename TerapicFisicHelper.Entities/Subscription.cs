using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Entities
{
    public class Subscription
    {
        [Required(ErrorMessage = "Debe asignar un cliente a la suscripcion")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Debe asignar un plan de suscripcion")]
        public int SubscriptionPlanId { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public virtual SubscriptionPlan SubscriptionPlan { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
