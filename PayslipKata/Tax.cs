namespace PayslipKata
{

    public class Tax
    {
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
          return 0;
        }
        else if (annualIncome > TaxBracketBMin && annualIncome < TaxBracketBMax)
        {
          return 0;
        }
        else if (annualIncome > TaxBracketCMin && annualIncome < TaxBracketCMax)
        {
           return (TaxBracketCBase + (annualIncome - TaxBracketBMax) * TaxBracketCMultiplier / 12);
        }
        else if (annualIncome > TaxBracketDMin && annualIncome < TaxBracketDMax)
        {
          return (TaxBracketDBase + (annualIncome - TaxBracketCMax) * TaxBracketDMultiplier / 12);
        }
        else if (annualIncome > TaxBracketE)
        {
          return (TaxBracketEBase + (annualIncome - TaxBracketDMax) * TaxBracketEMultiplier / 12);
        }
        else {
          return 4; //error here
        }
      }
    }
}