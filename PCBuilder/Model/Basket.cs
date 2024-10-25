using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PCBuilder.Model
{
    public class Basket
    {
        public event Action? OnCartUpdated;
        private List<CartItem> _items;
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public int Id { get; set; }
        public Component Component { get; set; }
        public Basket()
        {
            _items = [];
        }
        
        public void AddItem(Component component, int quantity)
        {
            var item = _items.FirstOrDefault(item => item.Component.Name == component.Name);

            if (item == null)
            {
                _items.Add(new CartItem { Component = component, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }

            OnCartUpdated?.Invoke();
        }
        public float GetTotalPrice()
        {
            return _items.Sum(i => i.TotalPrice);
        }
        public int Count()
        {
            return _items.Count;
        }
        public int GetQuantity(Component component)
        {
            var item = _items.FirstOrDefault(item => item.Component.Id == Component.Id);
            return item?.Quantity ?? 0;
        }
    }
}
