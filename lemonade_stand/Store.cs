using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    static class Store
    {
        // member variables (HAS A)

        static public double storeLemonPriceInDollars; // add bulk discount if there's time
        static public double storeBagOfSugarPriceInDollars;
        static public double storeBagOfIcePriceInDollars;


        // constructor  (SPAWNER)
        static Store()
        {
        }


        // member methods (CAN DO)


        static public double SetStoreSellingPriceOfLemons() 
        {
            return storeLemonPriceInDollars = 1;
        }

        static public double SetStoreSellingPriceOfSugar() 
        {
            return storeBagOfSugarPriceInDollars = 2;
        }

        static public double SetStoreSellingPriceOfIce() 
        {
            return storeBagOfIcePriceInDollars = 3;
        }


    }
}
