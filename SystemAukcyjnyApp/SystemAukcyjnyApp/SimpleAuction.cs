using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class SimpleAuction : AuctionBuilder
    {
        public override void BuildAuctionUser(User user)
        {
            auction.User = user;
        }

        public override void BuildDescription()
        {
            Console.WriteLine("Opis");
            auction.Desciption = Console.ReadLine();
        }

        public override void BuildMinPointsOfTrust()
        {
            try
            {
                Console.WriteLine("Punkty zaufania");
                auction.MinPointOfTrust = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Musisz podać liczbę");
                BuildStartPrice();
            }
            
        }

        public override void BuildNameOfAuction()
        {
            Console.WriteLine("Nazwa Aukcji");
            auction.NameOfAuction = Console.ReadLine();
        }

        public override void BuildStartPrice()
        {
            try
            {
                Console.WriteLine("Cena Początkowa");
                auction.StartPrice = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Musisz podać liczbę");
                BuildStartPrice();
            }
            
        }

        public override void BuildTimeOfAuction()
        {
            try
            {
                Console.WriteLine("Czas aukcji");
                auction.TimeOfAuction = int.Parse(Console.ReadLine());
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Musisz podać liczbę");
                BuildTimeOfAuction();
            }
        }

        public override User CheckPointsOfTrust(User user, AuctionBuilder actuallAuction, User winningUser)
        {
            if(user.PointOfTrust > actuallAuction.GetAuction().MinPointOfTrust)
            {
                Console.WriteLine("Jesteś w aukcji o nazwie " + actuallAuction.GetAuction().NameOfAuction);
                Console.WriteLine("Kwota aukcji: " + actuallAuction.GetAuction().StartPrice);
                Console.WriteLine("Jaką kwotę chciałbyś postawić (Jeśli chcesz ominąć turę podaj kwotę 0)");
                double money = Convert.ToDouble(Console.ReadLine());
                if(money > actuallAuction.GetAuction().StartPrice)
                {
                    actuallAuction.GetAuction().StartPrice = money;
                    winningUser.FirstName = user.FirstName;
                    winningUser.LastName = user.LastName;
                    winningUser.Login = user.Login;
                    winningUser.Mail = user.Mail;
                    winningUser.PointOfTrust = user.PointOfTrust;
                }
            }
            return winningUser;
        }

        public override void GetWinner(AuctionBuilder actuallAuction, User winningUser)
        {
            Console.WriteLine("Aukcja zostaje zakończona" + "\n");
            Console.WriteLine("Aukcje z kwotą" + actuallAuction.GetAuction().StartPrice + " wygrywa " + winningUser);
        }

        public override void NextTour(AuctionBuilder actuallAuction, User winningUser)
        {
            int tmp = actuallAuction.GetAuction().TimeOfAuction - 1;
            actuallAuction.GetAuction().TimeOfAuction = tmp;
            Console.WriteLine("Zostało " + actuallAuction.GetAuction().TimeOfAuction + " Tur");
             if(actuallAuction.GetAuction().TimeOfAuction == 0)
            {
                actuallAuction.GetWinner(actuallAuction, winningUser);
            }
        }

        public override string ToString()
        {
            return "Auction: " + auction;
        }
    }
}
