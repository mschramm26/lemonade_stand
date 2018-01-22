using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Lemons: Inventory
    {
        // member variables (HAS A)
        public double amount;


        // constructor (SPAWNER)
        public Lemons()
        {

        }


        // member methods (CAN DO)
        public double BuyLemonsFromStore(double lemonsBought) // subtract supplies used that day and/or add items purchased at store
        {
            return amount + lemonsBought;
        }

        public double UseLemonsToMakeLemonade(double lemonsUsed)
        {
            return amount - lemonsUsed;
        }

        public override double ReturnAmountOfLemons()
        {
            return amount;
        }



    }
}
