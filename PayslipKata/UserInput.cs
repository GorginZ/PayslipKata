using System;
namespace PayslipKata
{
  public class UserInput
  {
    //all types because all user input will be strings.
    //this also means it will be easier to validate and re-prompt in instance of invalid or wrong input
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string AnnualSalary { get; set; }
    public string SuperRate { get; set; }
    public string PaymentStart { get; set; }
    public string PaymentEnd { get; set; }
    //constructor
    public UserInput(string firstName, string surName, string annualSalary, string superRate, string paymentStart,string paymentEnd)
    {
        FirstName = firstName;
         SurName = surName;
         AnnualSalary = annualSalary;
         SuperRate = superRate;
         PaymentStart = paymentStart;
         PaymentEnd = paymentEnd;
        }

    public string GetFirstName()
    {
      Console.WriteLine("Please enter your first name:");
      var firstName = Console.ReadLine();
      return firstName;
    }

    public string GetSurName()
    {
      Console.WriteLine("Please enter your surname name:");
      var surName = Console.ReadLine();
      return surName;
    }
    public string GetAnnualSalary()
    {
      Console.WriteLine("Please enter your annual salary:");
      var annualSalary = Console.ReadLine();
      return annualSalary;
    }

    public string GetSuperRate()
    {
      Console.WriteLine("Please enter your Super Rate:");
      var superRate = Console.ReadLine();
      return superRate;
    }

     public string GetPaymentStart()
    {
      Console.WriteLine("Please enter the payment start date:");
      var paymentStart = Console.ReadLine();
      return paymentStart;
    }

       public string GetPaymentEnd()
    {
      Console.WriteLine("Please enter the payment end date");
      var paymentEnd = Console.ReadLine();
      return paymentEnd;
    }

  }
}