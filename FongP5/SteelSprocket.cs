using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP5
{
    class SteelSprocket : Sprocket
    {
        /// <summary>
        /// SteelSprocket parameterless Constructor inheriting from base
        /// </summary>
        SteelSprocket():base()
        { }
        /// <summary>
        /// Overloaded constructor inheriting from base overloaded constructor
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="numItems"></param>
        /// <param name="numTeeth"></param>
        public SteelSprocket(int itemID,int numItems, int numTeeth/*, int orderNum*/) :
            base(itemID,numItems,numTeeth)
        {
        }

        // Overridden Calculate method
        /// <summary>
        /// overriden Calculate method
        /// </summary>
        public override void Calculate()
        {
            Price = NumTeeth * .05M * NumItems;
        }

        // Overriden ToString() method
        /// <summary>
        /// Overriden ToString() method 
        /// </summary>
        /// <returns>
        /// returns base ToString() and adds "Material: Steel" to it
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + ", Material: Steel";
        }
    }
}
