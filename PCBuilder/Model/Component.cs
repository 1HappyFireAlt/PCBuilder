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
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double Rating { get; set; }
        public string? ImageUrl { get; set; }
    }
}
