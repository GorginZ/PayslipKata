using System;
namespace PayslipKata
{
  public class Payslip
  {
    public string Name { get; set; }
    public string PayPeriod { get; set; }
    public double GrossIncome { get; set; }
    public double IncomeTax { get; set; }
    public double NetIncome { get; set; }
    public double Super { get; set; }
    //constructor
    public Payslip(string name, string payPeriod, double grossIncome, double incomeTax, double netIncome, double super)
    {
      Name = name;
      PayPeriod = payPeriod;
      GrossIncome = grossIncome;
      IncomeTax = incomeTax;
      NetIncome = netIncome;
      Super = super;
    }

    public void PrintPayslip(Payslip payslip)
    {
      Console.WriteLine($" Name: {payslip.Name} \n Pay Period: {payslip.PayPeriod}\n Gross Income: {payslip.GrossIncome} \n Income Tax: {payslip.IncomeTax} \n Net Income: {payslip.NetIncome} \n Super: {payslip.Super}");
    }

    public static void GeneratePayslip()
    {
      Console.WriteLine("Welcome to payslip generator");

      var userInput = UserInput.GetUserInput();
      var payee = new Payee(userInput);
      var tax = new Tax(userInput.AnnualSalary);
      var payslip = new Payslip(payee.Name, payee.PayPeriod, payee.GrossIncome, payee.IncomeTax, payee.NetIncome, payee.Super);
      payslip.PrintPayslip(payslip);
    }

  }
}