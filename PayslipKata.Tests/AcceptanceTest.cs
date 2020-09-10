using Xunit;

namespace PayslipKata.Tests
{
    public class AcceptanceTest
    {
      [Fact]
      public void ShouldMakePayslipWithCorrectNumbers()
      {
      var userInput = new UserInput{FirstName = 
      "John", SurName = "Doe", AnnualSalary = "60050", SuperRate = "9", PaymentStart = "1 March", PaymentEnd = "March 31" };

      var payee = new Payee(userInput);
      var tax = new Tax(userInput.AnnualSalary);
      var payslip = new Payslip(payee.Name, payee.PayPeriod, payee.GrossIncome, payee.IncomeTax, payee.NetIncome, payee.Super);

            var expectedPayslip = new Payslip("John Doe", "1 March-31 March", 5004.00, 922.0, 4082.00, 450.00);

      // var expectedPayslip = new Payslip{ Name = "John Doe", PayPeriod = "1 March-31 March", GrossIncome = 5004.00, IncomeTax = 922.00, NetIncome = 4082.00, Super = 450.00 };

      Assert.Equal(expectedPayslip, payslip);
      } 
        
    }
}