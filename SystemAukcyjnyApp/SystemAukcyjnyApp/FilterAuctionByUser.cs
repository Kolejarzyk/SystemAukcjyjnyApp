using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
   public class FilterAuctionByUser : IFilterAuction
    {
        public void Filter(DatabaseOfAuctions database)
        {
            string login = Console.ReadLine();
            List<AuctionBuilder> listAfterFilter = database.getListOfAuction();

            foreach (var p in listAfterFilter.Where(p => (p.GetAuction().User.Equals(login)))) Console.WriteLine(p.GetAuction());
        }   
    }
}