using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCBuilder.Model
{
    public class Component
    { 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Rating { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Builds> Builds { get; set; }
        public ICollection<Basket> Baskets { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
