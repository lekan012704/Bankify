using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class Account
    {
        public string name { get; set; }
        public int password { get; set; }
        public int number { get; set; }

        public string address { get; set; }

       
        public  virtual void CreateAccount(string name , int password , int number, string address)
        {
            this.name = name;
            this.password = password;
            this.number = number;
            this.address = address;

            Console.WriteLine("Enter Your Full Name");

            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Your Password");

            password = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Phone Number");

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Full Address");

            address = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Account Details");
            Console.WriteLine($"Your Name is  : {name}");
            Console.WriteLine($"Your Password is : {password}");
            Console.WriteLine($"Your Phone Number is : {number}");
            Console.WriteLine($"Your Address is {address}");
        }
    }
}
