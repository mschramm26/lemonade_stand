using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Customer
    {
        // member variables (HAS A)
        //public Game game;

        public double chanceOfBuyingLemonade; // depends on recipe
                                              // create ~100 customer objects - use iteration. customers will have IF price is below X, customer will buy. IF NOT, customer will not buy.
                                              // actual customers and potential customers
                                              // taste preference
        public double cupsWantedToPurchase;
        public bool isBuyer;

        // constructor  (SPAWNER)
        public Customer()
        {
            // instantiate the ~100 customer objects from above here
        }

        // member methods (CAN DO)

        public bool WantsToBuy()
        {
            // generate random number 1-10
                // if random number is X, customer buys
            return isBuyer = true;
        }

        public double ChoosesNumberOfCupsToBuyIfBuying()
        {
            // IF AND ONLY IF WantsToBuy is true, generate random number between 1 and 10
               // if number is 1-6, customer buys 1 cup
               // if number is 7-10, customer buys 2 cups

            return cupsWantedToPurchase;
        }


    }
}
