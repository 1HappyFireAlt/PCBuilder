using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCBuilder.Model
{
    public class Component
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int Rating { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Builds> Builds { get; set; }
        public ICollection<ShopBasket> Baskets { get; set; }
    }
}
