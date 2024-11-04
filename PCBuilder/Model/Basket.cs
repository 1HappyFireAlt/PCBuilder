using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PCBuilder.Model
{
    public class Basket
    {
        public int Id { get; set; }
        public Component Component { get; set; }

        private List<Component> _items = new List<Component>();
        public event Action? OnCartUpdated;
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public int Count()
        {
            return _items.Count;
        }
        public Basket()
        {
            _items = [];
        }
        public void AddItem(Component component)
        {
            _items.Add(component);
            OnCartUpdated?.Invoke();  // Trigger the event
        }
    }
}
