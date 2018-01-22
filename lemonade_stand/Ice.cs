using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Ice : Inventory
    {
        // member variables (HAS A)
        public double amount;



        // constructor (SPAWNER)
        public Ice()
        {

        }


        // member methods (CAN DO)
        public double BuyBagsOfIceFromStore(double bagsBought) // subtract supplies used that day and/or add items purchased at store
        {
            return amount + bagsBought;
        }

        public double UseBagsOfIceToMakeLemonade(double bagsUsed)
        {
            return amount - bagsUsed;
        }

        public override double ReturnAmountOfBagsOfIce()
        {
            return amount;
        }

    }
}
