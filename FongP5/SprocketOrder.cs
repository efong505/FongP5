using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FongP5
{
    class SprocketOrder:Address
    {
        public SprocketOrder(string customerName, Address address, List<Sprocket> items )
        {
            CustomerName = customerName;
            Address = address;
            this.items = items;
        }

        public SprocketOrder():this("TBD",null,new List<Sprocket>()) { }

        private List<Sprocket> items;// = new List<Sprocket>();
    
        public List<Sprocket> Items
        { 
            get => items;
            set { items = value; Calc(); }
        }

        public string CustomerName { get; set; }
        public decimal TotalPrice { get; private set; }
        public Address Address { get; set; }
        
        // Add method
        public void Add(Sprocket item)
        {
            items.Add(item);
            Calc();
        }

        // Remove method
        public void Remove(Sprocket item)
        {
            items.Remove(item);
            Calc();
        }
        public void Calc()
        {
            TotalPrice = 0;
            foreach(var item in items)
            {
                TotalPrice += item.Price;
            }
        }
        public override string ToString()
        {
            string orderSummary = "";

            orderSummary += CustomerName + ": " +
                items.Count + " items, Total Price: $" + TotalPrice;
            if(Address != null)
            {
                orderSummary += "\nShip To:\n" + Address;
            }
            else
            {
                orderSummary += "\nLocal Pickup";
            }
                
            return orderSummary;
        }
    }

}
