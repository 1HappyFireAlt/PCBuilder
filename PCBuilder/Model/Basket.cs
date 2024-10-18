using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PCBuilder.Model
{
    public class Basket
    {
        public int Id { get; set; } 

        public List<BasketItem> Items { get; set; } = new List<BasketItem>(); 

        public float GetTotalPrice()
        {
            return Items.Sum(i => i.TotalPrice);
        }
    }
}
