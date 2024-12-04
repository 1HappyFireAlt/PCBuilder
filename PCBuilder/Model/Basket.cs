using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Components;

namespace PCBuilder.Model
{
    public class ShopBasket
    {
        public int Id { get; set; }

        public event Action? OnCartUpdated;
        private List<BasketItem> _items { get; set; } = new List<BasketItem>();
        public int Count()
        {
            return _items.Count;
        }
        public ShopBasket()
        {
            _items = [];
        }

        // This allows the admin to add new components to the shop
        public void AddItem(Component component, int quantity)
        {
            var existingItem = _items.FirstOrDefault(item => item.Id == component.Id);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _items.Add(new BasketItem { Component = component, Quantity = quantity });
            }
            OnCartUpdated?.Invoke(); 
        }

        //This allows the admin to remove old component or unavailable component from the shop
        public void RemoveItem(Component component)
        {
            _items.RemoveAll(_items => _items.Id == component.Id);
            OnCartUpdated?.Invoke();
        }

        public void RemoveItem(Component component, int quantity)
        {
            var item = _items.FirstOrDefault(item => item.Id == component.Id);
            if (item is not null)
            {
                item.Quantity -= quantity;
                if (item.Quantity <= 0)
                    _items.Remove(item);
            }
            OnCartUpdated?.Invoke();
        }
        public float TotalPrice()
        {
            return _items.Sum(item => item.Component.Price * item.Quantity);
        }

        public void Clear()
        {
            _items.Clear();
            OnCartUpdated?.Invoke();
        }

        public int GetQuantity(Component component)
        {
            var item = _items.FirstOrDefault(item => item.Id == component.Id);
            return item?.Quantity ?? 0;
        }
        public void SetItems(IEnumerable<BasketItem> items)
        {
            _items = items.ToList();
            OnCartUpdated?.Invoke();
        }

        public IEnumerable<BasketItem> GetItems()
        {
            return _items;
        }
    }
}
