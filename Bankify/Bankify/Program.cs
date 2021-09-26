using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Account();
            a.CreateAccount("sobuur",6774664,023048459,"No 17 G2 Street Federal Housing Estate");
            var b = new bankSystem();
            b.CreateAccount("sobuur", 6774664, 023048459, "No 17 G2 Street Federal Housing Estate");
        }
    }
}
