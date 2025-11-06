using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount : IBankAccount
    {

        public BankAccount(string id, string name, int balance) {
            _id = id;
            _name = name;
            _balance = balance;
        }

        public string _id { get; private set; }
        public string _name { get; private set; }
        public int _balance { get; private set; }

        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public void GetAccountInfo()
        {
            Console.WriteLine("Name: " + _name +", Balance: "+_balance +", ID:" + _id); 
        }

        public void Withdraw(int amount)
        {
            _balance -= amount;
        }
        public void Transfer(BankAccount account, int amount) {
            account._balance += amount;
            _balance -= amount;
        }
    }
}
