namespace PCBuilder.Model
{
    public class BasketItem
    {
        public int Id { get; set; } 
        public int BasketId { get; set; }

        public Component Component { get; set; }
        public Component Product { get; set; } 
        public int Quantity { get; set; }

        public float TotalPrice => Product.Price * Quantity;
    }
}
