using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    /// <summary>
    /// Class representing a bank account with basic operations.
    /// </summary>
    class BankAccount : IBankAccount
    {
        /// <summary>
        /// Constructor to initialize a bank account with ID, name and balance
        /// </summary>
        /// <param name="id">Set user id</param>
        /// <param name="name">Set user name</param>
        /// <param name="balance">Set user balance</param>
        public BankAccount(string id, string name, int balance) {
            _id = id;
            _name = name;
            _balance = balance;
        }

        public string _id { get; private set; }
        public string _name { get; private set; }
        public int _balance { get; private set; }
        /// <summary>
        /// Adds amount to the account balance
        /// </summary>
        /// <param name="amount">How much add to account</param>
        public void Deposit(int amount)
        {
            _balance += amount;
        }
        /// <summary>
        /// Displays the account information name, balance, and ID
        /// </summary>
        public void GetAccountInfo()
        {
            Console.WriteLine("Name: " + _name +", Balance: "+_balance +", ID:" + _id); 
        }
        /// <summary>
        /// Withdraws amount from the account balance
        /// </summary>
        /// <param name="amount">How much withdraws from account</param>
        public void Withdraw(int amount)
        {
            _balance -= amount;
        }
        /// <summary>
        /// Transfers amount from this account to another account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="amount"></param>
        public void Transfer(BankAccount account, int amount) {
            account._balance += amount;
            _balance -= amount;
        }
    }
}
