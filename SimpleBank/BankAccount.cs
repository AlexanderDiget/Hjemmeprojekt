using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount
    {
        private double balance;
        private string name;
        public string Name { get; set; }
       
        public double Balance
        {
            get { return balance; }
        }
        private bool locked;
        public BankAccount(double balance): this("", balance)
        {
            this.balance = balance;
        }
        public BankAccount(string name, double balance): this(name, balance, false)
        {
            this.name = name;
            this.balance = balance;
        }
        public BankAccount(string name, double balance, bool locked)
        {
            this.name= name;
            this.balance = balance;
            this.locked = locked;
        }
        public void Deposit(double amount)
        {
            if (!locked) // locked == false
            {
                balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (!locked && amount <= balance)
            {
                balance = balance - amount;

                // balance -= amount;
                //Console.WriteLine("Du må ikke trække flere penge end der på kontoen");
            }
        }
        public void ChangeLockState()
        {
            locked = !locked;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Balance: {balance}";
        } 
    }
}
