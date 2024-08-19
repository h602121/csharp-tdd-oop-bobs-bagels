﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private int _id;
        private int _capacity;
        public int Id { get { return _id; } set { _id = value; } }
        public int Capacity { get { return _capacity; }set { _capacity = value; } }

        private List<Item> _items;

        public List<Item> Items
        {
            get { return _items; }
  
        }

      
        public Basket(int capacity) { 
            this._items = new List<Item>();
            this._capacity = capacity;
        }

        public bool AddItem(Item item)
        {
            if (_items.Count >= _capacity){
                return false;
            }
            _items.Add(item);
            return true;
        }

        public bool RemoveItem(Item item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
                return true;
            }
            return false;
        }

        public double GetPrice()
        {
            double price = 0;
            foreach(var product in _items)
            {
                price += product.Price;
            }
            price = Math.Round(price, 2);
            return price;
        }

        public bool ChangeCapacity(Person person, int newCapacity)
        {
            if (person.Manager == true)
            {
                _capacity = newCapacity;
                return true;
            }
            return false;
        }

       
    }
}
