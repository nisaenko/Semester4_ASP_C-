// Solution: BasePlusCommissionEmployee.cs

using System;

public class BasePlusCommissionEmployee : CommissionEmployee
{
  
   private decimal baseSalary; // base salary per week

   // property that gets and sets base-salaried commission employee's base salary
   public decimal BaseSalary
   {
       get
       {
           return baseSalary;
       } // end get
       set
       {
           if (value >= 0)
               baseSalary = value;
           else
               throw new ArgumentOutOfRangeException("BaseSalary", value, "BaseSalary must be >= 0");
       } // end set
   } // end property BaseSalary
    
    // six-parameter constructor
   public BasePlusCommissionEmployee( string first, string last, string ssn, decimal sales, decimal rate, decimal salary )
       : base ( first, last, ssn, sales, rate )
   {
    
      BaseSalary = salary; // validate base salary via property
   } // end six-parameter BasePlusCommissionEmployee4 constructor

   

   // calculate base-salaried commission employee's earnings
   public override decimal Earnings()
   {
      return BaseSalary + base.Earnings();
      // return BaseSalary + CommissionRate * GrossSales;
   } // end method Earnings

   // return string representation of BasePlusCommissionEmployee4
   public override string ToString()
   {
      return string.Format( "base-salaried {0}\nbase salary: {1:C}", base.ToString(), BaseSalary );
   } // end method ToString
} // end class BasePlusCommissionEmployee
