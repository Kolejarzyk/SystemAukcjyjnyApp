using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool x = true;
            int i = 0;
            User user = new User("Pawel", "Dering", "Kolejarz", "pawel.dee@gmail.com", 22);
            User user1 = new User("Mateusz", "Mazalon", "Mati", "mat.maz@gmail.com", 0);
            User user2 = new User("Marcin", "Stencel", "L3N", "mar.ste@gmail.com", 13);
            User user3 = new User("Piotr", "Brzeski", "Piord", "pio.brze@gmail.com", 11);
            User user4 = new User("Emilia", "Roszmann", "Emi", "emi.rosz@gmail.com", 2);


            DatabaseOfUsers users = new DatabaseOfUsers();
            users.AddUser(user);
            users.AddUser(user1);
            users.AddUser(user2);
            users.AddUser(user3);
            users.AddUser(user4);

            int userNumber = 0;
            foreach (User allUser in users.GetListOfUsers())
            {
                
                Console.WriteLine(userNumber + ". " +allUser);
                userNumber++;
            }
            Console.WriteLine( "Witam W Systemie aukcyjnym "
                               + "\n Wybierz numer użytkownika");
            i = int.Parse(Console.ReadLine());
            User actuallUser = users.GetUser(i);
            DatabaseOfAuctions auctions = new DatabaseOfAuctions();
            do
            {
                Console.WriteLine("Witaj " + actuallUser.FirstName + ". Wybierz Operacje");
                Console.WriteLine("1.Tworzenie nowej aukcji" + "\n"
                                    + "2.Wybór aukcji z bazy" + "\n"
                                    + "3.Filtrowanie Aukcji" + "\n"
                                    + "4.Zmiana użytkownika" + "\n"
                                    + "5.Dodaj/odejmnij punkty zaufania" + "\n"
                                    + "6.Wyjście z programu");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        
                        MenuCreateAuction.CreateAuction(actuallUser, auctions);
                        break;
                    case 2:
                        MenuAuctionOperation.ChooseAuction(auctions, users);
                        break;
                    case 3:
                        MenuFilterAuction.FilterPick(auctions, users);
                        break;
                    case 4:
                        MenuChangeUser.ChangeUser(users, out actuallUser);
                        break;
                    case 5:
                        MenuPointOfTrustOperation.PointOfTrust(actuallUser, users);
                        break;
                    case 6:
                        x = false;
                        break;

                }
            }
            while (x);
            Console.WriteLine("Program zakończył działanie");

        }


    }
 }



