using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class MenuAuctionOperation
    {
        public static void ChooseAuction(DatabaseOfAuctions auctions, DatabaseOfUsers users)
        {
       
            Console.WriteLine("Wybierz numer aukcji");
            int i = int.Parse(Console.ReadLine());

            foreach (AuctionBuilder auction in auctions.getListOfAuction())
            {
                Console.WriteLine(auction);
            }

            AuctionBuilder actuallAuction = auctions.getAuction(i);
            User winningUser = new User();
            foreach (User user in users.GetListOfUsers())
            {
                Console.WriteLine("Kolej na " + user.FirstName + "\n");
                actuallAuction.CheckPointsOfTrust(user, actuallAuction, winningUser);
            }
            actuallAuction.NextTour(actuallAuction, winningUser);


        }
    }
}
