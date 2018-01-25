using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonade_stand
{
    public static class Wallet
    {
        // member variables (HAS A)
        public static double dollarsInWallet;

        // constructor (SPAWNER)
        static Wallet()
        {
        }

        // member methods (CAN DO)

        public static double ContainsMoneyInDollars()
        {
            return dollarsInWallet;
        }

        public static double ReceiveMoneyFromCustomer(double moneyReceived) {
            dollarsInWallet = dollarsInWallet + moneyReceived;
            return dollarsInWallet;
        }

        public static double PayMoneyToStore(double moneyPaid)
        {
            dollarsInWallet = dollarsInWallet - moneyPaid;
            return dollarsInWallet;
        }
    }
}
