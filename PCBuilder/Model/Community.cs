using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCBuilder.Model
{
    public class Community
    {
        public int Id { get; set; }

        [Required]
        public string Post { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Rating { get; set; }

        public ICollection<Builds> Builds { get; set; }
        public ICollection<ShopBasket> Baskets { get; set; }
    }
}
