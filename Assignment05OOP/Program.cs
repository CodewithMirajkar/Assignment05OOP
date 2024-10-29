//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment05OOP
//{

//    public class BankAccount
//    {
//        private string AccountNumber;
//        private string AccountHolder;
//        private double Balance;

//        public BankAccount(string AccountNumber)
//        {
//            double balance = 0;
//            this.AccountNumber = AccountNumber;
//            this.AccountHolder = AccountHolder;
//            this.Balance = Balance;
            

//        }
//        public void Deposit(double deposite)
//        {
//            if (deposite > 0)
//            {
//                Balance += deposite;
//                Console.WriteLine("{0} has been deposited & Current balance is {1}", deposite, deposite);
//            }
//            else
//            {
//                Console.WriteLine("Deposite amount is invalid");
//            }
//        }
//        public void Withdraw(double withdraw)
//        {
//            if (withdraw < Balance)
//            {
//                Balance -= withdraw;
//                Console.WriteLine("{0} has been withdraw & Current balance is {1}", withdraw, Balance);
//            }
//            else
//            {
//                Console.WriteLine("Insufficient balance to withdrawal");
//            }
//        }
//        public void ShowBalance()
//        {
//            Console.WriteLine("Current balance is {0}", Balance);
//        }
//        public string GetAccountNumber()
//        {
//            return AccountNumber;
//        }

//        public string GetAccountHolder()
//        {
//            return AccountHolder;
//        }
//        public double GetBalance()
//        {
//            return Balance;
//        }
//    }




//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount bankAccount = new BankAccount("Account Holder Name Vikas");
//            string res1 = bankAccount.GetAccountNumber();
//            Console.WriteLine(res1);


//            bankAccount.GetAccountHolder();
//            bankAccount.Deposit(1000);
//            bankAccount.Withdraw(100);
//            bankAccount.ShowBalance();
//            Console.ReadLine();
//        }

//    }
//}

