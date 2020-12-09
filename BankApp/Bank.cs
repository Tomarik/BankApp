using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Bank
    {
        public Account activeUser;
        private List<Account> accounts = new List<Account>();
        public void Add(Account account)
        {
            accounts.Add(account);
        }

        public bool Login(string username, string password)
        {
            foreach (Account account in accounts)
            {
                if (account.Password == password && account.Id == username)
                {
                    this.activeUser = account;
                    return true;
                }
            }

            return false;
                
            }

        public override string ToString()
        {
            return "Account Balance $" + activeUser.Balance.ToString();
        }

    }
    }

