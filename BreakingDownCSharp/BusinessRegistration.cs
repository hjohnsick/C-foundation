using System;
using System.Collections.Generic;
using System.Text;

namespace BreakingDownCSharp
{
    public class BusinessRegistration
    {
        string companyName;
        string purpose;
        string ownersName;
        DateTime preferredStartUpDate;
        decimal expectedMonthlySales = 0;

        decimal registrationFee = 125.50m;
        decimal processingFee = 90.00m;
        decimal dbaLookupFee = 110.25m;
        decimal extendedProcessingFee;
        DateTime submittionDate = DateTime.Now;
        decimal servicing;
        public decimal ExtendedProcessingFee()
        {
            int spanOfDays = (preferredStartUpDate.Date - submittionDate.Date).Days;
            
            extendedProcessingFee = spanOfDays * .05m;
            return extendedProcessingFee;
        }
        public decimal ServicingCalculation()
        {
            servicing = expectedMonthlySales * .08m;
            return servicing;
        }
        public decimal FeeCalculation()
        {
            decimal feeTotal = registrationFee + processingFee + dbaLookupFee + ServicingCalculation() + ExtendedProcessingFee();
            return feeTotal;
        }

        public int CalculateNumberOfMonths()
        {
            
            int numberOfMonths = ((preferredStartUpDate.Year -submittionDate.Year) * 12) + (preferredStartUpDate.Month - submittionDate.Month);
            return numberOfMonths;
        }
        public decimal CalculateMonthlyPaymentAmount()
        {
            decimal monthlyPaymentAmount = FeeCalculation() / CalculateNumberOfMonths();
            return monthlyPaymentAmount;
        }

        public void GatherInformation()
        {
            Console.WriteLine("Enter the company name: ");
            companyName = Console.ReadLine();

            Console.WriteLine("Enter the purpose of the business: ");
            purpose = Console.ReadLine();

            Console.WriteLine("Enter the company owner's name: ");
            ownersName = Console.ReadLine();

            Console.WriteLine("Enter the preferred business start date: ");
            preferredStartUpDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What are the expected monthly sales?");
            expectedMonthlySales = int.Parse(Console.ReadLine());
        }

        public void displayInformation()
        {
            Console.WriteLine($"Business registration for {companyName} - Owner {ownersName}\n\n");
            Console.WriteLine($"Submitted on: {submittionDate.ToShortDateString()} - Business start date : {preferredStartUpDate}\n\n");
            Console.WriteLine($"List of Fees:\n\n");
            Console.WriteLine($"{registrationFee}\n{processingFee}\n{dbaLookupFee}\n{ServicingCalculation()}\n{ExtendedProcessingFee()}\n\n\n");
            Console.WriteLine($"Total Fee Amount: {FeeCalculation()}\n\n");
            Console.WriteLine($"Payment Option: {CalculateMonthlyPaymentAmount()}");
        }
    }
}
