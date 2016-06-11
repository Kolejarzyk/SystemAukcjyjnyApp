using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public abstract class AuctionBuilder
    {
        protected Auction auction;


        public void NewAuction()
        {
            auction = new Auction();
        }
        public Auction GetAuction()
        {
            return auction;
        }
        



        public abstract void BuildNameOfAuction();
        public abstract void BuildDescription();
        public abstract void BuildStartPrice();
        public abstract void BuildTimeOfAuction();
        public abstract void BuildMinPointsOfTrust();
        public abstract void BuildAuctionUser(User user);

        public abstract void GetWinner(AuctionBuilder actuallAuction, User winningUser);
        public abstract void NextTour(AuctionBuilder actuallAuction, User winningUser);
        public abstract User CheckPointsOfTrust(User user, AuctionBuilder actuallAuction, User winningUser);
    }
}
