namespace PCBuilder.Model
{
    public class CartItem
    {
        public Component Component { get; set; }
        public int Quantity { get; set; }

        public float TotalPrice => Component.Price * Quantity;
    }
}
