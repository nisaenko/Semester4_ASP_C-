using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab01_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of CommissionEmployee class

        CommissionEmployee commEmployee = new CommissionEmployee ( "John", "Smith", "123456", 5000.00m, 0.5m);
        
        // displaying commission employee
        Console.WriteLine ( commEmployee );
         Console.WriteLine (commEmployee.Earnings ( )); // calculate commission/salary
         Console.WriteLine ( "\n" );
         
        // Creating an object of BasePlusCommissionEmployee class

         BasePlusCommissionEmployee basecommEmployee = new BasePlusCommissionEmployee ( "John", "Smith", "123456", 5000.00m, 0.5m,1000.00m );

         // displaying commission employee
         Console.WriteLine ( basecommEmployee );
         Console.WriteLine ( basecommEmployee.Earnings ( ) ); // calculate commission/salary
         Console.WriteLine ( "\n" );

         // Creating an object of HourlyEmployee class

         HourlyEmployee hourEmployee = new HourlyEmployee ( "John", "Smith", "123456", 50.00m, 5.0m );

         // displaying commission employee
         Console.WriteLine ( hourEmployee );
         Console.WriteLine ( hourEmployee.Earnings ( ) ); // calculate commission/salary
         Console.WriteLine ( "\n" );

        }
    }
}
