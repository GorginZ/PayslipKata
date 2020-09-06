namespace PayslipKata
{
  public class Payslip
  {
    //all types will be strings bc it's a payslip and the final product so nothing else needs to be manipulated and it must return strings.
    public string Name { get; set; }
    public string PayPeriod { get; set; }
    public string GrossIncome { get; set; }
    public string IncomeTax { get; set; }
    public string NetIncome { get; set; }
    public string Super { get; set; }
    //constructor
    // public Payslip() {
    //   Name = FullName;
    //   PayPeriod = payPeriod;
    //   GrossIncome = grossIncome;
    //   IncomeTax = incomeTax;
    //   NetIncome = netIncome;
    //   Super = super;
    // }

    public Payslip(UserInput userInput)
    {
      Name = FullName(userInput.FirstName, userInput.SurName);
      PayPeriod = PayslipPayPeriod(userInput.PaymentStart, userInput.PaymentEnd);
      GrossIncome = PayslipGrossIncome(userInput.AnnualSalary);
      IncomeTax = 

    }


    //function to concat first and last name for expected 'name' field in payslip 
    public static string FullName(string FirstName, string SurName) => $"{FirstName} {SurName}";
    //arrow function to concat entered payment periods in format expected in pay period field in payslip
    public static string PayslipPayPeriod(string PaymentStart, string PaymentEnd) => $"{PaymentStart}-{PaymentEnd}";

    public static string PayslipGrossIncome(string annualIncome)
    {
      int intAnnualIncome = int.Parse(annualIncome);
      int intGrossIncome = intAnnualIncome / 12;
      var grossIncome = intGrossIncome.ToString();
      return grossIncome;
    }

  }
}