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
        public Game Game;

        // constructor (SPAWNER)
        public Wallet()
        {
        }

        public double HasBeginningBalanceOf()
        {
            double beginningBalance = 50;
            return beginningBalance;
        }

        public double ContainsMoney()
        {
            return dollarsInWallet;
        }

        // member methods (CAN DO)
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
