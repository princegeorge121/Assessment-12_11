using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_12_11
{
    internal class Banking
    {
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }

        public int MobileNumber { get; set; }

        private int _accountBalance;

        public int AccountBalance
        {
            get { return _accountBalance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid Value");
                    return;
                }
                _accountBalance = value;
            }
        }

        public void CreateAccount()
        {
            Console.WriteLine("Enter Name : ");
            AccountName = Console.ReadLine();

            Console.WriteLine("Enter Account Number : ");
            AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile Number : ");
            MobileNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Account Created Successfully ....!!!!");

        }
        public void DepositCash()
        {
            Console.WriteLine("Enter Cash To Deposit : ");
            var Balance = Convert.ToInt32(Console.ReadLine());
            AccountBalance += Balance;
            Console.WriteLine("New Balance is : " + AccountBalance);

        }
        public void WithdrawCash()
        {
            Console.WriteLine("Enter Cash To Withdraw : ");
            var Balance = Convert.ToInt32(Console.ReadLine());
            if (AccountBalance - Balance < 0)
            {
                Console.WriteLine("Balance is Low to withdraw: " + AccountBalance);
                return;
            }
            AccountBalance -= Balance;
            Console.WriteLine("New Balance is : " + AccountBalance);

        }
        public void Balance()
        {
            Console.WriteLine("Name : " + AccountName);
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Balance is : " + AccountBalance);

        }
    }
}
