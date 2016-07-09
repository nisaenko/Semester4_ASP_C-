// Solution: BasePlusCommissionEmployee.cs

using System;

public class HourlyEmployee : CommissionEmployee
{
  
   private decimal hourlyRate; 
   private decimal hours; 

   // property that gets and sets hourly employee's hours and rate
   public decimal HourlyRate
   {
       get
       {
           return hourlyRate;
       } // end get
       set
       {
           if (value >= 0)
               hourlyRate = value;
           else
               throw new ArgumentOutOfRangeException("HourlyRate", value, "HourlyRate must be >= 0");
       } // end set
   } // end property HourlyRate

    // property that gets and sets base-salaried commission employee's base salary
   public decimal Hours
   {
       get
       {
           return hours;
       } // end get
       set
       {
           if (value >= 0)
               hours = value;
           else
               throw new ArgumentOutOfRangeException("Hours", value, "Hours must be >= 0");
       } // end set
   } // end property Hours
    
    // six-parameter constructor
   public HourlyEmployee(string first, string last, string ssn, decimal hrate, decimal hrs): base(first, last, ssn)
   {

       HourlyRate = hrate;
       Hours = hrs;
   } // end constructor

   

   // calculate base-salaried commission employee's earnings
   public override decimal Earnings()
   {
       return HourlyRate * Hours;
   } // end method Earnings

   // return string representation of BasePlusCommissionEmployee4
   public override string ToString()
   {
   return string.Format ( "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}", "hourly employee",
      FirstName, LastName, "social security number", SocialSecurityNumber,
          "Hourly-rate", HourlyRate, "Hours",Hours);
   } // end method ToString
} // end class BasePlusCommissionEmployee
