using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    static public class Inventory
    {

        // member variables (HAS A)
        static public double amountOfLemons; 
        static public double amountOfSugarInCups;
        static public double amountOfIceBags;



        // constructor  (SPAWNER)
        static Inventory()
        {
        }


        // member methods (CAN DO)

        /*START lemons*/
        static public  double ReturnCurrentAmountOfLemons()
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
        static public  double ReturnCurrentAmountOfCupsOfSugar()
        {
            return amountOfSugarInCups;
        }

        static public double BuyBagsOfSugarFromStore(double bagsBought) 
        {
            return amountOfSugarInCups + (bagsBought * 8);
        }
        static public double UseCupsOfSugarToMakeLemonade(double cupsOfSugarUsed)
        {
            return amountOfSugarInCups;
        }

        /*END sugar*/



        /*START ice*/
        static public  double ReturnCurrentAmountOfBagsOfIce()
        {
            return amountOfIceBags;
        }

        static public double UseBagsOfIceToMakeLemonade(double bagsUsed)
        {
            return amountOfIceBags - bagsUsed;
        }

        static public double BuyBagsOfIceFromStore(double bagsBought) // subtract supplies used that day and/or add items purchased at store
        {
            return amountOfIceBags + bagsBought;
        }
        /*END ice*/




    }
}
