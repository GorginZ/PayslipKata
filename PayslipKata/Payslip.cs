namespace PayslipKata
{
    public class Payslip
    {
      //all types will be strings bc it's a payslip and the final product so nothing else needs to be manipulated.
        public string Name { get; set;}
        public string PayPeriod { get; set; }
        public string GrossIncome { get; set; }
        public string IncomeTax { get; set; }
        public string NetIncome { get; set; }
        public string Super { get; set; }
//constructor
        public Payslip() {
          Name = name;
          PayPeriod = payPeriod;
          GrossIncome = grossIncome;
          IncomeTax = incomeTax;
          NetIncome = netIncome;
          Super = super;
        }
    }
}