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
        public Inventory storeLemons; 
        public Inventory storeCupsOfSugar;
        public Inventory storeBagsOfIce;

        public const double bulkDiscountNone = 1; // they will also be cheaper to buy in bulk, so will vary by quantity bought
        public const double bulkDiscountMultiplier = 0.1;
        public const double bulkDiscountExtraMultiplier = 0.2;

        // constructor  (SPAWNER)
        public Store()
        {
            storeLemons = new Inventory();
            storeCupsOfSugar = new Inventory();
            storeBagsOfIce = new Inventory();
        }


        // member methods (CAN DO)

        public double SetDiscountOnLemons(double quantityOfLemonsBought) //  pass in as parameter the amount being bought by the lemonade stand
        {
            if (quantityOfLemonsBought > 25 & quantityOfLemonsBought <= 50)
            {
                return bulkDiscountMultiplier;
            }
            if (quantityOfLemonsBought > 50)
            {
                return bulkDiscountExtraMultiplier;
            }
            else
            {
                return bulkDiscountNone;
            }
        }

        public void SetSellingPriceOfInventory()
        {
            // store's selling price will depend on quantity bought * bulk discount
            // if lemons bought is >= 20, discount is 20%
            // if cups of sugar bought >= is 100, discount is 20%
            // if bags of ice bought is >= 10, discount is 20%
        }


        public void SellInventoryToLemonadeStand()
        {
            // depends on how many lemonade stand wants to buy
        }


    }
}
