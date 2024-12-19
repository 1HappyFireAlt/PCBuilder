namespace PCBuilder.Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Component Component { get; set; }
        public int Quantity { get; set; }
        public float Total => Component.Price * Quantity;
    }
}
