using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace PayslipKata
{
  public class UserInput
  {
    [Required(ErrorMessage = "We need your first name")]
    [MaxLength(15, ErrorMessage = "First Name should not more than 1`5 character")]
    [MinLength(3, ErrorMessage = "First Name should be more than 2 characters")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name Required")]
    [MaxLength(15, ErrorMessage = "Last Name should not more than 1`5 character")]
    [MinLength(2, ErrorMessage = "Last Name should be more than 2 characters")]
    public string SurName { get; set; }

    [Required]
    // [RegularExpression("[^a-zA-Z]{10}", ErrorMessage = "Annual Salary must include numbers only")]
    public string AnnualSalary { get; set; }
    [Required]
    // [RegularExpression("[0-9]", ErrorMessage = "Your super rate must include numbers only")]
    public string SuperRate { get; set; }

    //would use enums here but kata specifies payment start and end as seperate entries.
    [Required]
    // [RegularExpression("^[0-9]+$", ErrorMessage = "Your work start your should only include numbers")]
    public string PaymentStart { get; set; }
    [Required]
    // [RegularExpression("^[0-9]+$", ErrorMessage = "Your work start your should only include numbers")] 
    public string PaymentEnd { get; set; }

    public static UserInput GetUserInput()
    {
      var userInput = new UserInput();

      var firstNameContext = new ValidationContext(userInput);
      userInput.FirstName = userInput.GetFirstName();
      userInput.FirstName = UserInput.TryValidatePropertyAndRepromptIfInvalid(userInput.FirstName, "FirstName", firstNameContext);

      var surNameContext = new ValidationContext(userInput);
      userInput.SurName = userInput.GetSurName();
      userInput.SurName = UserInput.TryValidatePropertyAndRepromptIfInvalid(userInput.SurName, "SurName", surNameContext);

      var annualSalaryContext = new ValidationContext(userInput);
      userInput.AnnualSalary = userInput.GetAnnualSalary();
      userInput.AnnualSalary = UserInput.TryValidatePropertyAndRepromptIfInvalid(userInput.AnnualSalary, "AnnualSalary", annualSalaryContext);

      var superRateContext = new ValidationContext(userInput);
      userInput.SuperRate = userInput.GetSuperRate();
      userInput.SuperRate = UserInput.TryValidatePropertyAndRepromptIfInvalid(userInput.SuperRate, "SuperRate", superRateContext);

      var paymentStartContext = new ValidationContext(userInput);
      userInput.PaymentStart = userInput.GetPaymentStart();
      userInput.PaymentStart = UserInput.TryValidatePropertyAndRepromptIfInvalid(userInput.PaymentStart, "PaymentStart", paymentStartContext);

      var paymentEndContext = new ValidationContext(userInput);
      userInput.PaymentEnd = userInput.GetPaymentEnd();
      userInput.PaymentEnd = UserInput.TryValidatePropertyAndRepromptIfInvalid(userInput.PaymentEnd, "PaymentEnd", paymentEndContext);

      return userInput;

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
    public static string TryValidatePropertyAndRepromptIfInvalid(string value, string propertyName, ValidationContext context)
    {
      context.MemberName = propertyName;

      var result = new List<ValidationResult>();
      var isValidProp = Validator.TryValidateProperty(value, context, result);

      while (!isValidProp)
      {
        foreach (var validation in result)
        {
          Console.WriteLine(validation.ErrorMessage);
        }

        Console.WriteLine("Please enter a valid entry for this field");

        value = Console.ReadLine();
        result = new List<ValidationResult>();
        isValidProp = Validator.TryValidateProperty(value, context, result);
      }
      Console.WriteLine($"OK..{value}");

      return value;
    }

  }
}