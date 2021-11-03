using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class SubscriptionModel
    {
        public int CustomerId { get; set; }
        public int SubscriptionPlanId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime StartDate { get; set; }
    }
}
