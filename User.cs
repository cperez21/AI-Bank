using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Bank
{
    public class User
    {
       public string userName;
        public string password;
        public bool hasChecking, hasSavings;
        Account acc_checking = new Account(Account.Type.Checking);
        Account acc_savings = new Account(Account.Type.Savings);
       
        /// <summary>
        ///Create a user with a name and accounts.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="addChecking"></param>
        /// <param name="addSavings"></param>
        public User(string typedName, string typedPassword, bool openChecking, bool openSavings)
        {
            userName = typedName;
            password = typedPassword;
            if(openChecking) {Accounts.checking = new Account(Account.Type.Checking);}
            if(openSavings) {Accounts.savings = new Account(Account.Type.Savings); }


        }

        public struct Accounts
        {
            public static Account checking, savings;


        }



       
       


        //Create User
        //Add new Account
       

      
    
    }//class end
}
