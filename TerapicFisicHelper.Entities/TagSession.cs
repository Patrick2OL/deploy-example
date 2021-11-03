using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Entities
{
    public class TagSession
    {
        [Required(ErrorMessage = "Debe asignar una tag")]
        public int TagId { get; set; }

        [Required(ErrorMessage = "Debe asignar una sesion")]
        public int SessionId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual Session Session { get; set; }
    }
}
