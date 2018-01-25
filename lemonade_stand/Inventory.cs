using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    public static class Inventory
    {

        // member variables (HAS A)
        public static double amountOfLemons; 
        public static double amountOfSugarInCups;
        public static double amountOfIceBags;



        // constructor  (SPAWNER)
        static Inventory()
        {
        }


        // member methods (CAN DO)

        /*START lemons*/
        public static double ReturnCurrentAmountOfLemons()
        {
            return amountOfLemons;
        }

        public static double BuyLemonsFromStore(double lemonsBought) 
        {
            return amountOfLemons + lemonsBought;
        }

        public static double UseLemonsToMakeLemonade(double lemonsUsed)
        {
            return amountOfLemons - lemonsUsed;
        }
        /*END lemons*/



        /*START sugar*/
        public static double ReturnCurrentAmountOfCupsOfSugar()
        {
            return amountOfSugarInCups;
        }

        public static double BuyBagsOfSugarFromStore(double bagsBought) 
        {
            return amountOfSugarInCups + (bagsBought * 8);
        }
        public static double UseCupsOfSugarToMakeLemonade(double cupsOfSugarUsed)
        {
            return amountOfSugarInCups;
        }

        /*END sugar*/



        /*START ice*/
        public static double ReturnCurrentAmountOfBagsOfIce()
        {
            return amountOfIceBags;
        }

        public static double UseBagsOfIceToMakeLemonade(double bagsUsed)
        {
            return amountOfIceBags - bagsUsed;
        }

        public static double BuyBagsOfIceFromStore(double bagsBought) 
        {
            return amountOfIceBags + bagsBought;
        }
        /*END ice*/




    }
}
