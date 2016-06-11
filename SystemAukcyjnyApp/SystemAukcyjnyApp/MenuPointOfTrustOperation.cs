using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class MenuPointOfTrustOperation
    {
        public static void PointOfTrust(User actuallUser, DatabaseOfUsers users)
        {
            Console.WriteLine("Wybierz numer użytkownika któremu chcesz dodać/odjąc punkty zaufania");

            int i = int.Parse(Console.ReadLine());
            User user = new User();
            user = users.GetUser(i);
            Console.WriteLine("Czy chcesz dodać czy odjąć punkty zaufania 1. Dodać 2.Odjąć");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    user.AddPointOfTrust();
                    break;
                case 2:
                    user.SubstractPointOfTrust();
                    break;
            }

        }
    }
}
