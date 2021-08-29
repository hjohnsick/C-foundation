using System;
using System.Collections.Generic;
using System.Text;

namespace BreakingDownCSharp
{
    public class CustomerInteraction
    {
        string firstName;
        string lastName;
        string preferredNickname;
        DateTime birthday;
        string customersCountryOfResidence;
        double discount = 0;
        double shipping;
        int points;
        int totalScore = 0;
        string productRecommendation;
        string colorQuestion = "What is your favorite color?";
        string favSeasonQuestion = "What is your favorite season?";
        string talkQuestion = "Who would you rather talk to, your mother, father, a stranger, aliens";
        string ratherQuestion = "Which would you rather be, wealthy, popular, accommodating, an alien";
        string color;
        string person;
        string season;
        string being;
        List<int> score = new List<int>();

        public void DisplayInformation()
        {
            GreetingTheCustomer();
            FigureOutBirthdayDiscount();
            DetermineShipping();
            AskAboutSurvey();
            CustomerSurvey();
          

        }
        private void GreetingTheCustomer()
        {
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("Do you have a preferred nickname? y/n");
            string response = Console.ReadLine();

            switch (response)
            {
                case "y":
                case "Y":
                case "yes":
                case "Yes":
                case "YES":
                    Console.WriteLine("What is your preferred nickname?");
                    preferredNickname = Console.ReadLine();
                    break;
                default:
                    preferredNickname = firstName;
                    break;
            }

            Console.WriteLine("What is your country of origin?");
            customersCountryOfResidence = Console.ReadLine();
        }

        private void DetermineShipping()
        {
            switch(customersCountryOfResidence)
            {
                case "US":
                case "Canada":
                case "Australia":
                    shipping = 0;
                    break;
                case "India":
                case "Germany":
                case "Brazil":
                case "Madagascar":
                    shipping = 289;
                    break;
                default:
                    shipping = 12.43;
                    break;

            }

            Console.WriteLine($"Your shipping cost is {shipping}");
            
        }

        private void AskAboutSurvey()
        {
            Console.WriteLine($"Would you like to continue by taking a survey? y/n");
            string response = Console.ReadLine().ToLower();

            if (response == "y" || response == "yes")
            {
                CustomerSurvey();
            }
            else
            Environment.Exit(0);
        }

        private void CustomerSurvey()
        {
            
            Console.WriteLine(colorQuestion);
            color = Console.ReadLine().ToLower();
            
            switch(color)
            {
                case "red":
                    points = 8;
                    score.Add(points);
                    break;
                case "blue":
                    points = 3;
                    score.Add(points);
                    break;
                case "yellow":
                    points = 6;
                    score.Add(points);
                    break;
                case "purple":
                    points = 1;
                    score.Add(points);
                    break;
                case "black":
                case "white":
                    points = 0;
                    score.Add(points);
                    break;
                default:
                    points = 5;
                    score.Add(points);
                    break;
            }

            Console.WriteLine(favSeasonQuestion);
           season = Console.ReadLine().ToLower();

            switch(season)
            {
                case "summer":
                    points = 4;
                    score.Add(points);
                    break;
                case "spring":
                    points = 9;
                    score.Add(points);
                    break;
                case "winter":
                    points = 2;
                    score.Add(points);
                    break;
                case "fall":
                    points = 11;
                    score.Add(points);
                    break;
                default:
                    points = 1;
                    score.Add(points);
                    break;
            }

            Console.WriteLine(talkQuestion);
            person = Console.ReadLine().ToLower();

            switch(person)
            {
                case "mother":
                    points = 1;
                    score.Add(points);
                    break;
                case "father":
                    points = 3;
                    score.Add(points);
                    break;
                case "stranger":
                    points = 8;
                    score.Add(points);
                    break;
                case "aliens":
                    points = 22;
                    score.Add(points);
                    break;
                default:
                    points = 0;
                    score.Add(points);
                    break;
            }
            Console.WriteLine(ratherQuestion);
            being = Console.ReadLine().ToUpper();

            switch(being)
            {
                case "wealthy":
                    points = 7;
                    score.Add(points);
                    break;
                case "popular":
                    points = 2;
                    score.Add(points);
                    break;
                case "accommodating":
                    points = 10;
                    score.Add(points);
                    break;
                case "alien":
                    points = 22;
                    score.Add(points);
                    break;
                default:
                    points = 0;
                    score.Add(0);
                    break;
            }

            DetermineProductRecommendation();
            DisplayProductRecommendation();
        }

        private string DetermineProductRecommendation()
        {
            foreach (var number in score)
            {
                totalScore = number + totalScore;
            }

            if (totalScore <= 10)
            {
                return productRecommendation = "Shoes made of Swiss Cheese";
            }
            else if (totalScore <= 20)
            {
                return productRecommendation = "Bottle opener shaped bottle opener";
            }
            else if (totalScore <= 30)
            {
                return productRecommendation = "Ben Franklin bowling pin";
            }
            else if (totalScore <= 40)
            {
                return productRecommendation = "Pickled elephant skull";
            }
            else
            {
                return productRecommendation = "A full sized black and white copy of Van Gogh's Starry Night.";
            }
        }

        private void DisplayProductRecommendation()
        {
            Console.WriteLine($"Thank you very much {preferredNickname} for stopping by and taking our survey!  " +
                $"We have a product recommendation for you based on your answers to the following questions.\n\n");

            Console.WriteLine($"{colorQuestion} : {color}");
            Console.WriteLine($"{favSeasonQuestion} : {season}");
            Console.WriteLine($"{talkQuestion} : {person}");
            Console.WriteLine($"{ratherQuestion} : {being}");

            Console.WriteLine($"Your answers have convinced us you would probably enjoy a {DetermineProductRecommendation()}." +
                $"If you don't already have one, you should consider buying one for your birthday in {NumberOfDaysUntilBirthday()}");

            if (discount != 0)
            {
                Console.WriteLine($"Don't forget you still have a {discount * 100}% discount you can use.");
            }
        }

        private int NumberOfDaysUntilBirthday()
        {
            return (birthday.Date - DateTime.Now.Date).Days;
        }
        private void FigureOutBirthdayDiscount()
        {
            Console.WriteLine("When is your birthday?");
            birthday = DateTime.Parse(Console.ReadLine());
            if (birthday.Date == DateTime.Today)
            {
                Console.WriteLine("You get a 15% discount on today's order!");
                discount = .15;
            }
            else if ((DateTime.Today - birthday.Date).TotalDays <= 14)
            {
                Console.WriteLine("Happy belated Birthday! You get 8% off todays order!");
                discount = .08;
            }
            else if ((birthday.Date - DateTime.Today).TotalDays <= 14)
            {
                Console.WriteLine("We have a birthday discount.  On your birthday save 15%!");
            }
        }
    }
}
