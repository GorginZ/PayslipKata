namespace PayslipKata
{
    public class UserInput
        {
      //all types because all user input will be strings.
      //this also means it will be easier to validate and re-prompt in instance of invalid or wrong input
        public string FirstName { get; set;}
        public string SurName { get; set; }
        public string AnnualSalary { get; set; }
        public string SuperRate { get; set; }
        public string PaymentStart { get; set; }
        public string PaymentEnd { get; set; }
//constructor
        public UserInput() {
         FirstName = firstName,
         Surname = surname,
         AnnualSalary = annualSalary,
         SuperRate = superRate,
         PaymentStart = paymentStart,
         PaymentEnd = paymentEnd

        }
    }
}