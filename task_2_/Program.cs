using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_
{
    public class BankAccount

    {
        // поля классф
        private string owner;
        private decimal balance;

    
        // доступ к полям класса
        public string Owner
        {
            get => owner;
            set => owner = value;
        }
        public decimal Balance
        {
            get => balance;
        }
        // конструктор
        public BankAccount(string owner, decimal balance)
        {
            this.owner = owner;
            this.balance = balance;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"{owner}, баланс: {balance}");

        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
            Console.WriteLine($"{owner}, баланс: {balance}");
        }
        public static void Main(String[] args)
        {
            BankAccount account = new BankAccount("Татьяна", 1500);
            account.Deposit(500);
            account.Withdraw(50);
            account.Withdraw(200);

        }
    }
}
