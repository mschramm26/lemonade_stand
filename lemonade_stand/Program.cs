﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Program
    {
        static void Main(string[] args)
        {

            Game playGame = new Game();
            playGame.PlayGame();

            Console.ReadLine();
            // Environment.Exit(0); 

        }
    }
}
