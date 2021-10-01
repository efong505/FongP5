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
        /// <summary>
        /// Class Properties
        /// </summary>
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; private set; }
        public Address Address { get; set; }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="address"></param>
        /// <param name="items"></param>
        public SprocketOrder(string customerName, Address address, List<Sprocket> items )
        {
            CustomerName = customerName;
            Address = address;
            this.items = items;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SprocketOrder():this("TBD",null,new List<Sprocket>()) { }

        private List<Sprocket> items;
    
        /// <summary>
        /// Items list
        /// </summary>
        public List<Sprocket> Items
        { 
            get => items;
            set { items = value; Calc(); }
        }

     
        
        /// <summary>
        /// Add Method
        /// </summary>
        /// <param name="item"></param>
        public void Add(Sprocket item)
        {
            items.Add(item);
            Calc();
        }

        /// <summary>
        /// Remove function using Remove()
        /// </summary>
        /// <param name="item"></param>
        public void Remove(Sprocket item)
        {
            items.Remove(item);
            Calc();
        }
        
        /// <summary>
        /// Overloaded Remove function using RemoveAt()
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            items.RemoveAt(index);
            Calc();
        }

        /// <summary>
        /// Calc Function
        /// </summary>
        public void Calc()
        {
            TotalPrice = 0;
            foreach(var item in items)
            {
                TotalPrice += item.Price;
            }
        }

        /// <summary>
        /// To String function
        /// </summary>
        /// <returns>either Shit To or Local Pickup string</returns>
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
