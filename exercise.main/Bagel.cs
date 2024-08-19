﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Bagel : Item
    {

        private int _id;
        public int Id
        { 
            get { return _id; } 
            set {  _id = value; }       
        }
        private string _sku;
        public string Sku
        {
            get { return _sku; }
            set { _sku = value; }
        }
        private string _name;
        public string Name
        {
            get => _name; set => _name = value;
        }
        private double _price;
        public double Price
        {
            get => _price; set => _price = value;
        }
        private string _variant;
        public string Variant
        {
            get => _variant; set => _variant = value;
        }

        private List<Item> _fillings;

        public Bagel(string sku, double price, string name, string variant)
        {
            this._sku = sku;
            this._name = name;
            this._price = price;
            this._variant = variant;
            this._fillings = new List<Item>();
        }


        public string AddFilling(string nameFilling)
        {
            List<Item> inventory = Inventory.GetInventory();

            foreach (var item in inventory)
            {
                if (item.Name.Equals(nameFilling))
                {
                    _fillings.Add(item);
                    return "Filling added";
                }
            }
            return "Filling not in inventory";
        }

        public bool RemoveFilling(string filling1)
        {
            foreach (var item in _fillings)
            {
                if (item.Name.Equals(filling1))
                {
                    _fillings.Remove(item);
                    return true;
                }
            }
            return false;
            
        }
    }
}
