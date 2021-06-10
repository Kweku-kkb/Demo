using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Welcome To ATM Service *********");
            Console.Write("Enter Your PIN: ");
            long pin = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer(pin);
            BankATM atm = new BankATM(customer);

        }
    }

    class BankATM
    {
        Customer user;
        public BankATM(Customer user)
        {
            this.user = user;
            int val = 0;
            
            while (val != 4)
            {
                Console.WriteLine("1. Check Account Balance");
                Console.WriteLine("2. Make a Deposit");
                Console.WriteLine("3. Make a Withdrawal");
                Console.WriteLine("4. Quit");
                Console.WriteLine("*******************************");
                Console.WriteLine("Enter a number: ");
                val = Convert.ToInt32(Console.ReadLine());

                switch (val)
                {
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                    case 1:
                        CheckAccountBalance();
                        break;
                    case 2:
                        DepositAmount();
                        break;
                    case 3:
                        WithdrawAmount();
                        break;
                    case 4:
                        Console.WriteLine("Thank you!");
                        break;
                }
            }
        }
        void CheckAccountBalance()
        {
            Console.WriteLine($"Your Current Balance is: {user.GetAccountBalance()}");
        }
        void DepositAmount()
        {
            Console.WriteLine("Enter your deposit amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            user.DepositAmount(amount);
        }
        void WithdrawAmount()
        {
            Console.WriteLine("Enter your withdrawal amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            user.WithdrawAmount(amount);
        }
    }
}
