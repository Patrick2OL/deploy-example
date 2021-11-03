using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class HistoryModel
    {
        public int CustomerId { get; set; }
        public int SessionId { get; set; }
        public DateTime Watched { get; set; }
    }
}
