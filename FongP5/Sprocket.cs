using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP5
{
    /// <summary>
    /// Abstract Sprocket Class
    /// </summary>
    public abstract class Sprocket
    {
        // Constructors
        
        // Overloaded Constructor
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="itemID">ItemID</param>
        /// <param name="numItems">NumItems</param>
        /// <param name="numTeeth">NumTeeth</param>
        /// 
        protected Sprocket(int itemID, int numItems, int numTeeth)
        {
            OrderNum = itemID;
            NumItems = numItems;
            NumTeeth = numTeeth;
            Calculate();
        }

        // Parameterless Constructor
        /// <summary>
        /// Parameterless Constructor
        /// </summary>
        protected Sprocket():this(-1,1,1)
        {
        }

        // Properties
        // NumItems Property
        /// <summary>
        /// NumItems property
        /// </summary>
        public int NumItems
        {
            get => _numItems;
            set{ _numItems = value; Calculate(); }
        }

        // Backing field for NumItems Property
        /// <summary>
        /// backing field for NumItems Property
        /// </summary>
        protected int _numItems;
        // Number of Teeth property
        /// <summary>
        /// NumTeeth property
        /// </summary>
        public int NumTeeth
        {
            get => _numTeeth;
            set { _numTeeth = value; Calculate(); }
        }
        // NumTeeth backin field
        /// <summary>
        /// backing field for NumTeeth Property
        /// </summary>
        protected int _numTeeth;

        // Read Only Properties
        // Read Only ItemID
        /// <summary>
        /// Read only ItemID Property
        /// </summary>
        public int ItemID { get; set; }
        
        // Read only Price Property
        /// <summary>
        /// Read only Price Property
        /// </summary>
        public decimal Price { get; set; }
        // auto properties
        /// <summary>
        /// Order Number Property
        /// </summary>
        public int OrderNum { get; set ; }

        // Methods
        // Abstract Calculate Method
        /// <summary>
        /// Abstract Calculate method
        /// </summary>
        public abstract void Calculate(); 
        public override string ToString()
        {
            return "Order Number: " + OrderNum + ", Number of Items: "
                + NumItems + ", Teeth: " + NumTeeth + ", Price: $" + Price;
        }
        
    }
}
