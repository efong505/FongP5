using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP5
{
    class AluminumSprocket : Sprocket
    {
        /// <summary>
        /// Default constructor inheriting from base constructor
        /// </summary>
        public AluminumSprocket() : base() { }

        /// <summary>
        /// Overloaded chained construrctor inheriting from base class
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="numItems"></param>
        /// <param name="numTeeth"></param>
        public AluminumSprocket(int itemID, int numItems, int numTeeth) :
            base(itemID, numItems, numTeeth)
        {
        }

        public override void Calculate()
        {
            Price = NumTeeth * .04M * NumItems;
        }
        public override string ToString()
        {
            return base.ToString() + " Material: Aluminum";
        }
    }
}
