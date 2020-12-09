using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account
    {
        private string id;
        private decimal balance;
        private string password;
        private string customer;

        public Account(string id, decimal balance, string password, string customer)
        {
            this.id = id;
            this.balance = balance;
            this.customer = customer;
            this.password = password;
        }
        public string Id { get { return id; } }
        public string Password { get { return password; } }
        public string Customer { get { return customer; } }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
