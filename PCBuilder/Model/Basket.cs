﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PCBuilder.Model
{
    public class ShopBasket
    {
        public int Id { get; set; }

        public event Action? OnCartUpdated;
        public List<BasketItem> _items { get; set; } = new List<BasketItem>();
        public int Count()
        {
            return _items.Count;
        }
        public ShopBasket()
        {
            _items = [];
        }
        public IEnumerable<BasketItem> GetItems()
        {
            return _items;
        }

        public void AddItem(Component Component, int quantity)
        {
            var item = _items.FirstOrDefault(item => item.Id == Component.Id);
            if (item == null)
            {
                _items.Add(new BasketItem { Component = Component, Quantity = quantity });
            }
            else
            {
                    item.Quantity += quantity;
            }
            OnCartUpdated?.Invoke(); 
        }
        public int Count()
        {
            return _items.Count;
        }

        public float TotalPrice()
        {
            return _items.Sum(item => item.Component.Price * item.Quantity);
        }

        public IEnumerable<BasketItem> GetItems()
        {
            return _items;
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
        public int GetQuantity(Component Component)
        {
            var item = _items.FirstOrDefault(item => item.Id == Component.Id);
            return item?.Quantity ?? 0;
        }
    }
}
