using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    class Wallet
    {
        // member variables (HAS A)
        public double dollarsInWallet;

        // constructor (SPAWNER)
        public Wallet()
        {
        }

        // member methods (CAN DO)

        public double ContainsMoneyInDollars()
        {
            return dollarsInWallet;
        }

        public void PrintBeginningBalance(double currentBalance)
        {
            Console.WriteLine("You have " + currentBalance + " in your wallet.");
        }

        public double ReceiveMoneyFromCustomer(double moneyReceived) {
            dollarsInWallet = dollarsInWallet + moneyReceived;
            return dollarsInWallet;
        }

        public double PayMoneyToStore(double moneyPaid)
        {
            dollarsInWallet = dollarsInWallet - moneyPaid;
            return dollarsInWallet;
        }
    }
}
