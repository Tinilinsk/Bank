using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        void Withdraw(int amount);
        void GetAccountInfo();
        void SavingAccount(decimal interestRate, int months);
    }
