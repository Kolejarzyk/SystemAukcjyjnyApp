using System;

namespace SystemAukcyjnyApp
{
    internal class ExtendedAuction : AuctionBuilder
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
            Console.WriteLine("Nazwa aukcji");
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
            if (user.PointOfTrust > actuallAuction.GetAuction().MinPointOfTrust)
            {
                Console.WriteLine("Jesteś w aukcji o nazwie " + actuallAuction.GetAuction().NameOfAuction);
                Console.WriteLine("Kwota aukcji: " + actuallAuction.GetAuction().StartPrice);
                Console.WriteLine("Jaką kwotę chciałbyś postawić (Jeśli chcesz ominąć turę podaj kwotę 0)");
                var money = Convert.ToDouble(Console.ReadLine());
                if (money > actuallAuction.GetAuction().StartPrice)
                {
                    actuallAuction.GetAuction().StartPrice = money;
                    winningUser.FirstName = user.FirstName;
                    winningUser.LastName = user.LastName;
                    winningUser.Login = user.Login;
                    winningUser.Mail = user.Mail;
                    winningUser.PointOfTrust = user.PointOfTrust;
                }
                else if (money == 0)
                {
                    Console.WriteLine("Ominięcie tury");
                }
                else
                {
                    Console.WriteLine("Podana kwota jest za niska. Najwyższa kwota" +
                                      actuallAuction.GetAuction().StartPrice + "Straciłeś kolejkę");
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
            double tmpMoney = 0;
            var tmp = actuallAuction.GetAuction().TimeOfAuction - 1;
            if (tmpMoney != actuallAuction.GetAuction().StartPrice)
            {
                if (tmp == 0)
                {
                    tmpMoney = actuallAuction.GetAuction().StartPrice;
                    tmp = actuallAuction.GetAuction().TimeOfAuction + 1;
                    actuallAuction.GetAuction().TimeOfAuction = tmp;
                    Console.WriteLine("Aukcja została przedłużona");
                }
                else
                {
                    tmpMoney = actuallAuction.GetAuction().StartPrice;
                    actuallAuction.GetAuction().TimeOfAuction = tmp;
                    Console.WriteLine("Zostało " + actuallAuction.GetAuction().TimeOfAuction + " Tur");
                }
            }
            else
            {
                if (actuallAuction.GetAuction().TimeOfAuction == 0)
                {
                    actuallAuction.GetWinner(actuallAuction, winningUser);
                }
                else
                {
                    tmp = actuallAuction.GetAuction().TimeOfAuction - 1;
                    actuallAuction.GetAuction().TimeOfAuction = tmp;
                    Console.WriteLine("Użytkownicy aukcji nie podbili ceny");
                    Console.WriteLine("Zostało " + actuallAuction.GetAuction().TimeOfAuction + " Tur");
                }
            }
        }

        public override string ToString()
        {
            return "Auction: " + auction;
        }
    }
}