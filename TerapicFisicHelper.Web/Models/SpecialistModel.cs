using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class SpecialistModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Specialty { get; set; }
    }
}
