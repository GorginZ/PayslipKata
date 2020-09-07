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
    public double Grossincome { get; set; }
    public double IncomeTax { get; set; }
    public double NetIncome { get; set; }
    public double Super { get; set; }

    public Payee(UserInput userInput)
    {
      FirstName = userInput.FirstName;
      SurName = userInput.SurName;
      AnnualSalary = double.Parse(userInput.AnnualSalary);
      SuperRate = double.Parse(userInput.SuperRate);
      PaymentStart = userInput.PaymentStart;
      PaymentEnd = userInput.PaymentEnd;

      Grossincome = PayslipGrossIncome(userInput.AnnualSalary);
      IncomeTax = ;
      NetIncome = CalcPayslipNetIncome(Grossincome, incomeTax);
    
    }

    

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
    }
}