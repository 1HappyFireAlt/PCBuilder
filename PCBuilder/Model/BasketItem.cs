namespace PCBuilder.Model
{
    public class BasketItem
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public Component Component { get; set; }
        public ComponentCategory Category { get; set; }
        public int Quantity { get; set; }
    }
}
