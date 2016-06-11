using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class DatabaseOfAuctions
    {
        private List<AuctionBuilder> auctions = new List<AuctionBuilder>();

        public void addAuction(AuctionBuilder auction)
        {
            auctions.Add(auction);
        }

        public AuctionBuilder getAuction(int i)
        {
            return auctions.ElementAt(i);
        }

        public List<AuctionBuilder> getListOfAuction()
        {
            return auctions;
        }
    }
}
