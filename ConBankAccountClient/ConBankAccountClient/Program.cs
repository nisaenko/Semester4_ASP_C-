using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConBankAccountClient
{
    class Program
    {
        
static void Main(string[] args)
        {


            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            int bal =100;
            Console.WriteLine("Please put your money in bank account. Your balance is: " + bal);
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(client.Deposit(bal, f));
            bal = bal + f;
            Console.WriteLine(client.Balance(bal));
            //Console.WriteLine(" Your balance is: " + bal);
            Console.WriteLine("Please withdraw your money:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(client.Withdaw(bal, d));
            bal = bal - d;
            Console.WriteLine(client.Balance(bal));
            Console.ReadLine();



        }
    }
}
