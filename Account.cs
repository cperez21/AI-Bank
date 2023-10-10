using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Bank
{
    public class Account
    {
        /// <summary>
        /// Balance on the account.
        /// </summary>
        float balance;
        /// <summary>
        /// Interest rate percentage that the account will increase by.
        /// </summary>
        float interestRate;
        
        public enum Type
        {
            Checking,
            Savings
        }


       public Account(Type enterHere)
       {
       
       }

    }
}
