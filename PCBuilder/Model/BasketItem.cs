namespace PCBuilder.Model
{
    public class BasketItem
    {
        public int Id { get; set; } 
        public int BasketId { get; set; }
        public Component Component { get; set; }
        public int Quantity { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

    }
}
