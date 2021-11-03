using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class UpdateSubscriptionModel
    {
        [Required(ErrorMessage = "Debe asignar un cliente a la suscripcion")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Debe asignar un plan de suscripcion")]
        public int SubscriptionPlanId { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
    }
}
