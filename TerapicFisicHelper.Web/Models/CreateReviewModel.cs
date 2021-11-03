using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Web.Models
{
    public class CreateReviewModel
    {
        [Required(ErrorMessage = "Todo Revision debe tener una descripción")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Descripcion del cliente debe tener entre 3 a 255 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Debe asignar un rank a la revision")]
        public int Rank { get; set; }

        [Required(ErrorMessage = "Debe asignar un cliente a la revision")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Debe asignar un especialista a la revision")]
        public int SpecialistId { get; set; }
    }
}
