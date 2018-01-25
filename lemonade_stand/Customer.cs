using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    public class Customer
    {
        // member variables (HAS A)

        public double chanceOfBuyingLemonade; // depends on recipe
                                              // customers will have IF price is below X, customer will buy. IF NOT, customer will not buy.
                                              // actual customers and potential customers
                                              // taste preference
        public double cupsWantedToPurchase;
        public bool isBuyer;

        public double frugalityScale;
        public double thirstiness;





        // constructor (SPAWNER)
        public Customer(double frugalityScale, double thirstinessScale) 
        {
            
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



        // depends on weather. more customers when weather is good.
        // IF weather = good [define good], THEN numberOfCustomers = high [define high]
        // IF weather = bad [define bad], THEN numberOfCustomers = low [define low]


    }
}
