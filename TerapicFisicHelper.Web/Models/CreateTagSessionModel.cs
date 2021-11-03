using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class CreateTagSessionModel
    {
        [Required(ErrorMessage = "Debe asignar una tag")]
        public int TagId { get; set; }

        [Required(ErrorMessage = "Debe asignar una sesion")]
        public int SessionId { get; set; }
    }
}
