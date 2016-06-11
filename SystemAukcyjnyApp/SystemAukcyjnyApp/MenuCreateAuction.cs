using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class MenuCreateAuction
    {
       
        public static void CreateAuction(User actuallUser, DatabaseOfAuctions auctions)
        {

            Console.WriteLine("Podaj Typ Aukcji którą chcesz utworzyć");
            Console.WriteLine("1.Prosta Aukcja" + "\n"
                              + "2.Rozsrzerzona aukcja" + "\n");

           
            int i = int.Parse(Console.ReadLine());
            AuctionBuilder auction;
            switch (i)
            {
                case 1:
                    auction = new SimpleAuction();
                    actuallUser.MakeAuction(auction, auctions);
                    break;
                case 2:
                    auction = new ExtendedAuction();
                    actuallUser.MakeAuction(auction, auctions);
                    break;

            }

        }
    }
}
