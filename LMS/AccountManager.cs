using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public static class AccountManager
    {
        //static List<Account> accounts = new List<Account>() { new Account("admin", "admin", "admin@gmail.com", "admin") };
        private static List<Account> accounts = new List<Account>()
        {
            new Account("admin", "admin", "admin@gmail.com", "admin")
        };

        public static List<Account> Accounts
        {
            get { return accounts; }
        }

        public static void AddAccount(string user, string pass, string email, string role)
        {
            accounts.Add(new Account(user, pass, email, role));
        }
    }
}
