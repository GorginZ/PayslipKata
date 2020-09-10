using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PayslipKata
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to payslip generator");
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


      var payee = new Payee(userInput);
      var tax = new Tax(userInput.AnnualSalary);
      var payslip = new Payslip(payee.Name, payee.PayPeriod, payee.GrossIncome, payee.IncomeTax, payee.NetIncome, payee.Super);
      payslip.PrintPayslip(payslip);
    }
  }
}
