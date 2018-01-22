using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Player
    {
        // member variables (HAS A)
        public string playerName;
        public Game Game;


        // constructor (SPAWNER)
        public Player()
        {

        }


        // member methods (CAN DO)

        public string GetName()
        {
            Console.WriteLine("Please enter your name.");
            playerName = Console.ReadLine(); // validate this?
            return playerName;
        }

    }
}
