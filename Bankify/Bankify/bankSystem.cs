using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class bankSystem : Account
    {
        public string name { get; set; }

        public int password { get; set; }
        public override void CreateAccount(string name, int password, int number, string address)
        {
          

            Console.WriteLine("Enter Your Name");

            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Your Password");

            password = Convert.ToInt32(Console.ReadLine());

            if (this.name == name && this.password == password )
            {
                int balance = 10000;
                int deposit;
                int withdraw;
                int transfer;
                // Declaring Choice Varaible
                int choice;
                // Various Operation
                Console.WriteLine("Welcome to Bankify");
                Console.WriteLine("Choose from 1-4 to Perform your Operation");
                Console.WriteLine("1. Deposit Money ");
                Console.WriteLine("2. Withdrawl Money ");
                Console.WriteLine("3. Check Balance ");
                Console.WriteLine("4 .Transfer Money ");
                Console.WriteLine("5. Exit the Program ");
                Console.WriteLine();
                // Declaring Users Choice
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Amount to be Deposited");

                            //Declaring deposit 
                            deposit = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Amount Deposited is {deposit}");

                            //Declaring Amount
                             var Amount = balance + deposit;

                            Console.WriteLine($"Your Current Balance is {Amount}");

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Amount to be Withdrawn");

                            //Declaring withdraw variable
                             withdraw = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Amount Withdrawn is {withdraw}");
                              var Amount = balance - withdraw;

                            Console.WriteLine($"Your Current Balance is {withdraw}");

                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine($"Your Current Balance is {balance}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter Amount to be Transfered");

                            // Declaring Tranfer Varaible
                            transfer = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Amount Transferred was {transfer}");

                            var amount = balance - transfer;

                            Console.WriteLine($"Your Current Balance is : {amount}");

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Close the Bank App");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Close the Bank App");
            }
        }
    }
}
