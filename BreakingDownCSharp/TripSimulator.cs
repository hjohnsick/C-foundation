using System;
using System.Collections.Generic;
using System.Text;

namespace BreakingDownCSharp
{
    public class TripSimulator
    {
        int milesPerGallon;
        double currentPricePerGallon;
        int milesToDestination;
        double pricePerNight;
        int numberOfNights;
        double fuel;
        double food;
        double lodging;
        double oddities;
        double otherCosts;
        int numberOfStops;
        double totalCost;
        double costSpentToDestination;
        double costDriveBackHome;
        double costStay;
        List<double> fuelCharges = new List<double>();
        public void GetInformation()
        {
            Console.WriteLine("Enter vehicle miles per gallon: ");
            milesPerGallon = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the current price per gallon: ");
            currentPricePerGallon = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the miles to destination: ");
            milesToDestination = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per night: ");
            pricePerNight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of nights: ");
            numberOfNights = int.Parse(Console.ReadLine());
        }

        public void CostOfFillingAnEmptyTank()
        {
            fuel = milesPerGallon * currentPricePerGallon;
            Console.WriteLine($"The cost of fuel is {fuel}.");
        }

        public void DriveToDestination(double foodAndDrinkExpenses)
        {
            CostOfFillingAnEmptyTank();
            Console.WriteLine("You have traveled {} miles so far.");
            Console.WriteLine("Do you want to spend money on food and drinks?");
            string response = Console.ReadLine().ToLower();
            switch (response)
            {
                case "yes":
                case "y":
                    Console.WriteLine("How much do you want to spend?");
                    foodAndDrinkExpenses = double.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }
                
        }

        public void DestinationStay()
        {

        }

        public void DriveBackHome()
        {

        }

        public void TotalCost()
        {
            totalCost = food + fuel + lodging + oddities + otherCosts;
        }
        public void ExpenseReport()
        {
            Console.WriteLine($"Your simulated trip has completed.  On your drive to your destination, you stopped {numberOfStops} times" +
                $"and spent {costSpentToDestination}.  While you were in town, you spent a total of {costStay}.  On your way home, you spent {costDriveBackHome}." +
                $"\nYour total cost for the trip was {totalCost}.\n\nYour itemized breakdown is:\n" +
                $"Fuel: {fuel}\nFood: {food}\nLodging: {lodging}\n Oddities: {oddities}\n Other Costs: {otherCosts}");
        }
    }
}
