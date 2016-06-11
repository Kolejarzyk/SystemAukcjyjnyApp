using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class Auction
    {
        public String NameOfAuction { get; set; }
        public String Desciption { get; set; }
        public double StartPrice { get; set; }
        public int TimeOfAuction { get; set; }
        public int MinPointOfTrust { get; set; }
        public User User { get; set; }


        public override string ToString()
        {
            return "Auction: " + NameOfAuction + " " + Desciption + StartPrice + TimeOfAuction + User;
        }

    }
}
