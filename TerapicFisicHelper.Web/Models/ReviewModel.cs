using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class ReviewModel
    {
        public string Description { get; set; }
        public int Rank { get; set; }
        public int CustomerId { get; set; }
        public int SpecialistId { get; set; }
    }
}
