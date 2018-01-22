using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Inventory
    {

        // member variables (HAS A)
        public Game Game;
        public double quantityOfItem;
        public double sellPrice;

        // constructor  (SPAWNER)
        public Inventory()
        {
        }


        // member methods (CAN DO)


        public virtual double ReturnAmountOfLemons()
        {
            return ReturnAmountOfLemons();
        }

        public virtual double ReturnAmountOfBagsOfSugar()
        {
            return ReturnAmountOfBagsOfSugar();
        }

        public virtual double ReturnAmountOfBagsOfIce()
        {
            return ReturnAmountOfBagsOfIce();
        }

    }
}
