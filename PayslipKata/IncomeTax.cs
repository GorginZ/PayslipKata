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

    public class IncomeTax
    {
      //list
     public int[] TaxBracketA = {0, 18200};
     public int[] TaxBracketB = {18201, 37000};
     public int[] TaxBracketC = {37001, 87000};

    public int [] TaxBracketD = {87001, 180000};

    public int [] TaxbracketE = {180, 001};
    }
}