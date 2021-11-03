using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class SubscriptionPlanModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
    }
}
