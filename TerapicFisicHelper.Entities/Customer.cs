using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerapicFisicHelper.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Todo cliente debe tener una descripción")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Descripcion del cliente debe tener entre 3 a 255 caracteres")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Debe incluir el codigo del usuario")]
        public int UserId { get; set; }
        
        public User User { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<History> Histories { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
