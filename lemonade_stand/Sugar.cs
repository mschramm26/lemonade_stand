using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Sugar : Inventory
    {
        // member variables (HAS A)
        public double amount;



        // constructor (SPAWNER)
        public Sugar()
        {

        }


        // member methods (CAN DO)

        public double BuyBagsOfSugarFromStore(double bagsBought) // subtract supplies used that day and/or add items purchased at store
        {
            return amount + bagsBought;
        }

        public double UseBagsOfSugarToMakeLemonade(double bagsUsed)
        {
            return amount;
        }

        public override double ReturnAmountOfBagsOfSugar()
        {
            return amount;
        }
    }
}
