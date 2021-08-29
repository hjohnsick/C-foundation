using System;

namespace BreakingDownCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var registration = new BusinessRegistration();
            //registration.GatherInformation();
            //registration.displayInformation();
            //var displayInformation = new CustomerInteraction();
            //displayInformation.DisplayInformation();
            var collectionsPractice = new CollectionsPractice();
            //collectionsPractice.DisplayGreetingToFriends();
            //collectionsPractice.DisplayLunchBuddies();
            //collectionsPractice.DisplayAverageGrade();
            collectionsPractice.DisplayGuestList();
            collectionsPractice.InviteMorePeople();
            collectionsPractice.UninviteTwoPeople();
            collectionsPractice.CutGuestListInHalf();
        }
    }
}
