using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        [Required, MinLength(1)]
        public int Count { get; set; }
    }
}
