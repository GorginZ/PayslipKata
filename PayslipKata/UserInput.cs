using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace PayslipKata
{
  public class UserInput
  {
    //all user input is strings, can perform validation here on UserInput properties and easily re-prompt
    [Required(ErrorMessage = "First Name Required")]
    [MaxLength(15, ErrorMessage = "First Name should not more than 1`5 character")]
    [MinLength(3, ErrorMessage = "First Name should be more than 2 characters")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name Required")]
    [MaxLength(15, ErrorMessage = "Last Name should not more than 1`5 character")]
    [MinLength(2, ErrorMessage = "Last Name should be more than 2 characters")]
    public string SurName { get; set; }

    [Required]
    [RegularExpression("[0-9]", ErrorMessage = "Annual Salary must include numbers only")]
    public string AnnualSalary { get; set; }
    [Required]
    [RegularExpression("[0-9]", ErrorMessage = "Your super rate must include numbers only")]
    public string SuperRate { get; set; }

    [Required]
    // [RegularExpression("^[0-9]+$", ErrorMessage = "Your work start your should only include numbers")]
    public string PaymentStart { get; set; }
    [Required]
    // [RegularExpression("^[0-9]+$", ErrorMessage = "Your work start your should only include numbers")] 
    public string PaymentEnd { get; set; }
    //constructor
    public UserInput(string firstName, string surName, string annualSalary, string superRate, string paymentStart, string paymentEnd)
    {
      FirstName = GetFirstName();
      SurName = GetSurName();
      AnnualSalary = GetAnnualSalary();
      SuperRate = GetSuperRate();
      PaymentStart = GetPaymentStart();
      PaymentEnd = GetPaymentEnd();
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