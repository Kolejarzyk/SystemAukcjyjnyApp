using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class User
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Login { get; set; }
        public String Mail { get; set; }
        public AuctionBuilder AuctionBuilder { get; set; }
        public int PointOfTrust { get; set; }
        public Double CostOfMoney { get; set; }

        public User()
        {

        }

        public User(String firstName, String lastName, String login, String mail, int pointOfTrust)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Mail = mail;
            this.PointOfTrust = pointOfTrust;
        }

        private void ConstructAuction(DatabaseOfAuctions database)
        {
            AuctionBuilder.NewAuction();
            AuctionBuilder.BuildNameOfAuction();
            AuctionBuilder.BuildDescription();
            AuctionBuilder.BuildStartPrice();
            AuctionBuilder.BuildTimeOfAuction();
            AuctionBuilder.BuildMinPointsOfTrust();
            AuctionBuilder.BuildAuctionUser(this);
            database.addAuction(this.AuctionBuilder);

        }
            public void MakeAuction(AuctionBuilder auctionBuilder, DatabaseOfAuctions database)
            {
                AuctionBuilder = auctionBuilder;
                ConstructAuction(database);
            }

        public void AddPointOfTrust()
        {
            this.PointOfTrust += 1;
        }

        public void SubstractPointOfTrust()
        {
            this.PointOfTrust -= 1;
        }

        public override string ToString()
        {
            return "Imie= " +  FirstName + ", Nazwisko= " + LastName + ",Login= " + Login + ", Mail= " + Mail + ",Punkty Zaufania= " + PointOfTrust + "\n";
        }
    }
    }

    
    

