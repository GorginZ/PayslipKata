using System;
namespace PayslipKata
{
  public class Payslip
  {
    //all types will be strings bc it's a payslip and the final product so nothing else needs to be manipulated and it must return strings.
    public string Name { get; set; }
    public string PayPeriod { get; set; }
    public double GrossIncome { get; set; }
    public double IncomeTax { get; set; }
    public double NetIncome { get; set; }
    public double Super { get; set; }
    //constructor
    public Payslip(string name, string payPeriod, double grossIncome, double incomeTax, double netIncome, double super) {
      Name = name;
      PayPeriod = payPeriod;
      GrossIncome = grossIncome;
      IncomeTax = incomeTax;
      NetIncome = netIncome;
      Super = super;
    }

    public void PrintPayslip(Payslip Payslip)
    {
      Console.WriteLine($"Name {Payslip.Name} \nPay Period: {Payslip.PayPeriod}\n Gross Income: {Payslip.GrossIncome} \n Income Tax: {Payslip.IncomeTax} \n Net Income: {Payslip.NetIncome} \n Super: {Payslip.Super}" );
    }

    // public Payslip(UserInput userInput)
    // {
    //   Name = FullName(userInput.FirstName, userInput.SurName);
    //   PayPeriod = PayslipPayPeriod(userInput.PaymentStart, userInput.PaymentEnd);
    //   GrossIncome = PayslipGrossIncome(userInput.AnnualSalary);
    //   IncomeTax = PayslipIncomeTax();

    // }


    //function to concat first and last name for expected 'name' field in payslip 

 


  }
}