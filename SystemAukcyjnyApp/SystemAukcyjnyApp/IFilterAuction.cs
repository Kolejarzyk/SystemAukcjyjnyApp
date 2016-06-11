using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public  interface IFilterAuction
    {
        void Filter(DatabaseOfAuctions database);
    }
}
