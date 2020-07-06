using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP5
{
    class SteelSprocket : Sprocket
    {
        

        SteelSprocket():base()
        { }

        public SteelSprocket(int itemID,int numItems, int numTeeth/*, int orderNum*/) :
            base(itemID,numItems,numTeeth)
        {
           // OrderNum = orderNum;
        }
        public override void Calculate()
        {
            Price = NumTeeth * .05M * NumItems;
        }

        public override string ToString()
        {
            return base.ToString() + " Material: Steel";
        }
    }
}
