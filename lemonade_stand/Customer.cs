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

        //public double chanceOfBuyingLemonade; // depends on recipe, taste preference (add later)
        public static double cupsWantedToPurchase;
        private double frugalityScale; // IF price is below X, customer will buy. IF NOT, customer will not buy.
        public static double thirstinessScale;

        int lowerLimit = 1;
        int upperLimit = 11;


        // constructor (SPAWNER)
        public Customer(double FrugalityScale, double ThirstinessScale) 
        {
            //lowerLimit = 1;
            //upperLimit = 11;
            //frugalityScale = Convert.ToDouble(Game.rnd.Next(lowerLimit, upperLimit));
            frugalityScale = FrugalityScale;
            //thirstinessScale = Convert.ToDouble(Game.rnd.Next(lowerLimit, upperLimit));
            thirstinessScale = ThirstinessScale;
        }



        // member methods (CAN DO)

        public double FrugalityScale
        {
            get
            {
                return frugalityScale;
            }
            set
            {
                frugalityScale = Convert.ToDouble(Game.rnd.Next(lowerLimit, upperLimit));
            }
        }




        public static double ChoosesNumberOfCupsToBuyIfAny(double thirstinessScale) 
        {
            if (thirstinessScale <= 2)
            {
                cupsWantedToPurchase = 0;
            }
            if (thirstinessScale >= 9)
            {
                cupsWantedToPurchase = 2;
            }
            else
            {
                cupsWantedToPurchase = 1;
            }
            return cupsWantedToPurchase;
        }


    }
}
