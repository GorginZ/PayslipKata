namespace PayslipKata
{
  public class Payee
  {
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public double AnnualSalary { get; set; }
    public double SuperRate { get; set; }
    public string PaymentStart { get; set; }

    public string PaymentEnd { get; set; }

    // public string Name { get; set; }
    public string Name { get; set; }
    public string PayPeriod { get; set; }
    public double GrossIncome { get; set; }
    public double IncomeTax { get; set; }
    public double NetIncome { get; set; }
    public double Super { get; set; }

    public Tax Tax { get; set; }

    public Payee(UserInput userInput)
    {
      FirstName = userInput.FirstName;
      SurName = userInput.SurName;
      AnnualSalary = double.Parse(userInput.AnnualSalary);
      SuperRate = double.Parse(userInput.SuperRate);
      PaymentStart = userInput.PaymentStart;
      PaymentEnd = userInput.PaymentEnd;

      Name = FullName(FirstName, SurName);
      PayPeriod = PayslipPayPeriod(PaymentStart, PaymentEnd);
      GrossIncome = PayslipGrossIncome(userInput.AnnualSalary);
      Tax = new Tax(userInput.AnnualSalary);
      IncomeTax = Tax.IncomeTax;
      NetIncome = CalcPayslipNetIncome(GrossIncome, IncomeTax);
      Super = CalcSuper(GrossIncome, SuperRate);

    }


    public static string FullName(string FirstName, string SurName) => $"{FirstName} {SurName}";
    //arrow function to concat entered payment periods in format expected in pay period field in payslip
    public static string PayslipPayPeriod(string PaymentStart, string PaymentEnd) => $"{PaymentStart}-{PaymentEnd}";

     

    public static double PayslipGrossIncome(string annualIncome)
    {
      int intAnnualIncome = int.Parse(annualIncome);
      int intGrossIncome = intAnnualIncome / 12;
      // var grossIncome = intGrossIncome.ToString();
      return intGrossIncome;
    }
    public static double CalcPayslipNetIncome(double grossIncome, double incomeTax)
    {
      double netIncome = (grossIncome - incomeTax);
      return netIncome;
    }

    public double CalcSuper(double GrossIncome, double SuperRate)
    {
      return GrossIncome * SuperRate;

    }

  }
}