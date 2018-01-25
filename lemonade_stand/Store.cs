using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    public static class Store
    {
        // member variables (HAS A)

        public static double storeLemonPriceInDollars; // could add bulk discount
        public static double storeBagOfSugarPriceInDollars;
        public static double storeBagOfIcePriceInDollars;


        // constructor  (SPAWNER)
        static Store()
        {
        }


        // member methods (CAN DO)


        public static double SetStoreSellingPriceOfLemons() 
        {
            return storeLemonPriceInDollars = 1;
        }

        public static double SetStoreSellingPriceOfSugar() 
        {
            return storeBagOfSugarPriceInDollars = 2;
        }

        public static double SetStoreSellingPriceOfIce() 
        {
            return storeBagOfIcePriceInDollars = 3;
        }


    }
}
