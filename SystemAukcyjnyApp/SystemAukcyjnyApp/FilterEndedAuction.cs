using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
   public  class FilterEndedAuction : IFilterAuction
    {
        public void Filter(DatabaseOfAuctions database)
        {
            List<AuctionBuilder> listAfterFilter = database.getListOfAuction();

            foreach (var p in listAfterFilter.Where(p => (p.GetAuction().TimeOfAuction == 0))) Console.WriteLine(p.GetAuction());
        }
    }
}
