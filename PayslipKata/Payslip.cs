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
      IncomeTax = PayslipIncomeTax();

    }


    //function to concat first and last name for expected 'name' field in payslip 
    public static string FullName(string FirstName, string SurName) => $"{FirstName} {SurName}";
    //arrow function to concat entered payment periods in format expected in pay period field in payslip
    public static string PayslipPayPeriod(string PaymentStart, string PaymentEnd) => $"{PaymentStart}-{PaymentEnd}";

    public static int PayslipGrossIncome(string annualIncome)
    {
      int intAnnualIncome = int.Parse(annualIncome);
      int intGrossIncome = intAnnualIncome / 12;
      // var grossIncome = intGrossIncome.ToString();
      return intGrossIncome;
    }


// Taxable Income 	Tax on this Income
// $0 - $18,200 	Nil
// $18,201 - $37,000 	19c for each $1 over $18,200
// $37,001 - $87,000 	$3,572 plus 32.5c for each $1 over $37,000
// $87,001 - $180,000 	$19,822 plus 37c for each $1 over $87,000
// $180,001 and over 	$54,232 plus 45c for each $1 over $180,000

// For example, the payment in March for an employee with an annual salary of $60,050 and a super rate of 9% is:

//     pay period = Month of March (01 March to 31 March)
//     gross income = 60,050 / 12 = 5,004.16666667 (round down) = 5,004
//                income tax = (3,572 + (60,050 - 37,000) x 0.325) / 12 = 921.9375 (round up) = 922
//     net income = 5,004 - 922 = 4,082
//     super = 5,004 x 9% = 450.36 (round down) = 450



    public static string PayslipIncomeTax(int intGrossIncome)
    {

      if (intGrossIncome < 18200)
    {
      intIcomeTax = ()
    }
      return incomeTax;
    }

  }
}