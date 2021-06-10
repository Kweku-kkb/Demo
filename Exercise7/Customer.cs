using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Customer
    {
        private decimal balance;
        private long pin;

        public Customer(long pin, decimal balance = 1000m)
        {
            this.pin = pin;
            this.balance = balance;
        }
        public void DepositAmount(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Amount deposited successful. Your current balance is: {balance}");
        }
        public decimal GetAccountBalance()
        {
            return balance;
        }
       
        public void WithdrawAmount(decimal amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                Console.WriteLine($"Amount withdrawn successful. Your current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Action not successful. You have insufficient balance");
                Console.WriteLine($"Your current balance is: {balance}");
            }
        }


    }
}
