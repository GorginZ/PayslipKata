namespace PayslipKata
{

//   The following rates for 2017-18 apply from 1 July 2017:
// Taxable Income 	Tax on this Income
// $0 - $18,200 	Nil
// $18,201 - $37,000 	19c for each $1 over $18,200
// $37,001 - $87,000 	$3,572 plus 32.5c for each $1 over $37,000
// $87,001 - $180,000 	$19,822 plus 37c for each $1 over $87,000
// $180,001 and over 	$54,232 plus 45c for each $1 over $180,000

// For example, the payment in March for an employee with an annual salary of $60,050 and a super rate of 9% is:

//     pay period = Month of March (01 March to 31 March)
//     gross income = 60,050 / 12 = 5,004.16666667 (round down) = 5,004
//     income tax = (3,572 + (60,050 - 37,000) x 0.325) / 12 = 921.9375 (round up) = 922
//     net income = 5,004 - 922 = 4,082


//tax class so any changes can all happen here, no magic numbers, any logic for tax can reference this class.

    public class Tax
    {
      //list

    //  public double[] TaxBracketA = {0, 18200};
    //  public double[] TaxBracketB = {18201, 37000};
    //  public double[] TaxBracketC = {37001, 87000};

    // public double [] TaxBracketD = {87001, 180000};

    // public double [] TaxbracketE = {180, 001};
    public double AnnualIncome { get; set; }

    public double IncomeTax { get; set; }

    public double TaxBracketAMin = 0;
    public double TaxBracketAMax = 18200;
    public double TaxBracketABase = 0;
    public double TaxBracketAMultiplier = 0;
    

    public double TaxBracketBMin = 18201;
    public double TaxBracketBMax = 37000;
    public double TaxBracketBBase = 0;
    public double TaxBracketBMultiplier = 0.19;

    public double TaxBracketCMin = 37001;
    public double TaxBracketCMax = 87000;
    public double TaxBracketCBase = 3572;
    public double TaxBracketCMultiplier = 0.325;

    public double TaxBracketDMin = 87001;
    public double TaxBracketDMax = 180000;
    public double TaxBracketDBase = 19822; 
    public double TaxBracketDMultiplier = 0.37;

    public double TaxBracketE = 180001;
    public double TaxBracketEBase = 54232;
    public double TaxBracketEMultiplier = 0.45;
    

      public double CalcIncomeTax(double annualIncome) 
      {
         
        if (annualIncome > 0 && annualIncome < 18200)
        {

          return (TaxBracketAMin + TaxbracketAMax);
        }
        else if (annualIncome > 18201 && annualIncome < 37000)
        {
          return 4;
        }
        //taxbracketC
        else if (annualIncome > TaxBracketCMin && annualIncome < TaxBracketCMax)
        {
          //     income tax = (3,572 + (60,050 - 37,000) x 0.325) / 12 = 921.9375 (round up) = 922
           return (TaxBracketCBase + (annualIncome - TaxBracketBMax) * TaxBracketCMultiplier / 12);
        }
        else {
          return 4; //error here
        }
      }
    }
}