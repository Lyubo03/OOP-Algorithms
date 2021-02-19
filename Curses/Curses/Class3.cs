using System;
using System.Collections.Generic;
using System.Text;

namespace Curses
{
    class BancAccount
    {
        private int id;
        private double balance;
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return id;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposite(double amount)
        {
            balance += amount;
        }
        public void Whithdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public override string ToString()
        {
            return $"Account ID {id}, balance {balance}";
        }
    }
}
