using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakingDownCSharp
{
    public class CollectionsPractice
    {
        string[] friends = { "Ben", "Luke", "Madi" };
        string[] lunchBuddies = new string[8];
        List<string> guestList = new List<string>();
        public void DisplayGreetingToFriends()
        {
            foreach(var friend in friends)
            {
                Console.WriteLine($"Hello {friend}");
            }
        }

        public void DisplayLunchBuddies()
        {
            friends.CopyTo(lunchBuddies, 0);
            lunchBuddies[3] = "Ed";
            lunchBuddies[4] = "Sandy";
            lunchBuddies[5] = "Thomas";
            lunchBuddies[6] = "Phylis";
            lunchBuddies[7] = "Kathy";
            foreach(var friend in lunchBuddies)
            {
                Console.WriteLine($"Hello, {friend}!  There are {lunchBuddies.Length} people on the list.");
            }
        }

        public void DisplayAverageGrade()
        {
            int[] testScores = new int[10];
            for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Enter test score: ");
                testScores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Your average score is {testScores.Average()}.");
            if(testScores.Average() < 80)
            {
                Console.WriteLine("Your grounded!");
            }
        }

        public void DisplayGuestList()
        {
            guestList.Add("Dawn");
            guestList.Add("Jeff");
            guestList.Add("Ben");

            foreach(var guest in guestList)
            {
                Console.WriteLine($"{guest} you're invited to my party!");
            }
        }

        public void InviteMorePeople()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Who do you want to invite to the party?");
                guestList.Add(Console.ReadLine());
            }

            Console.WriteLine("\n The Guest List is: ");

            foreach(var guest in guestList)
            {
                Console.WriteLine(guest);
            }

            Console.WriteLine($"\n");
        }

        public void UninviteTwoPeople()
        {
            for(int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Who should I uninvite?");
                string guest = Console.ReadLine();
                guestList.Remove(guest);
            }

            Console.WriteLine($"\nGuest List after uninviting 2 people");

            foreach(var guest in guestList)
            {
                Console.WriteLine(guest);
            }

            Console.WriteLine($"\n");
        }

        public void CutGuestListInHalf()
        {
            List<string> waitingList = new List<string>();

            int numInGuestList = guestList.Count();

            double halfOfGuestList = numInGuestList * .5;

            int half = (int)Math.Round(halfOfGuestList);
            guestList.RemoveRange(half - 1, half);

            Console.WriteLine("New Guest List:\n");
            foreach(var guest in guestList)
            {
                Console.WriteLine(guest);
            }

        }
    }
}
