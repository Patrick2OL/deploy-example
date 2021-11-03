using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class CreateHistoryModel
    {
        [Required(ErrorMessage = "Debe asignar un cliente al historial")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Debe asignar una sesion al historial")]
        public int SessionId { get; set; }

        [Required]
        public DateTime Watched { get; set; }
    }
}
