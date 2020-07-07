using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP5
{
    class PlasticSprocket : Sprocket
    {
        //Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public PlasticSprocket() : base() { }

        // Overloaded Constructor Inheriting from base constructor chained
        /// <summary>
        /// Overloaded Chained Constructor inheriting from base constructor
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="numItems"></param>
        /// <param name="numTeeth"></param>
        public PlasticSprocket(int itemID, int numItems, int numTeeth):
            base(itemID, numItems, numTeeth)
        {
        }

        // Overridden Calculate method
        /// <summary>
        /// Overridden Calculate method
        /// </summary>
        public override void Calculate()
        {
            Price = NumTeeth * .02M * NumItems;
        }
        // Overridden ToString() method
        /// <summary>
        /// Overridden ToString() method
        /// </summary>
        /// <returns>
        /// returns base ToString() and adds "Material: Plastic" to it
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + ", Material: Plastic";
        }
    }
}
