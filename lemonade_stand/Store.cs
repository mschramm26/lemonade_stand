using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Store
    {
        // member variables (HAS A)

        public double storeLemonPriceInDollars;
        public double storeBagOfSugarPriceInDollars;
        public double storeBagOfIcePriceInDollars;


        // constructor  (SPAWNER)
        public Store()
        {
        }


        // member methods (CAN DO)


        public double SetStoreSellingPriceOfLemons() // store's selling price will depend on quantity bought * bulk discount
        {
            return storeLemonPriceInDollars = 1;
        }

        public double SetStoreSellingPriceOfSugar() // store's selling price will depend on quantity bought * bulk discount
        {
            return storeBagOfSugarPriceInDollars = 2;
        }

        public double SetStoreSellingPriceOfIce() // store's selling price will depend on quantity bought * bulk discount
        {
            return storeBagOfIcePriceInDollars = 3;
        }


    }
}
