namespace PCBuilder.Model
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<OrderItem> Items { get; set; } = [];
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }
        public float Total => Items.Sum(item => item.Component.Price * item.Quantity);
    }
    public enum OrderStatus
    {
        None,
        Placed,
        Dispatched,
        Cancelled,
    }
}
