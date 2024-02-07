using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL03_labsheet02_Q02
{
    public class bankAccount
    {
        public int accountNumber;

        public double Balance;
        public void deposit(double amount)
        {
            Balance = Balance+amount;
        }

    }
    public class program
    {
        static void Main(string[] args)
        {
            bankAccount account = new bankAccount();
            Console.Write("Enter the account number: ");
            account.accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the diposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            account.deposit(amount);

            Console.WriteLine("Account number: " + account.accountNumber);
            Console.WriteLine("updated Balance: " + account.Balance);

            Console.ReadLine();
        }
    }
       



    


    
}

