using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
   public class MenuChangeUser
    {
        public static User ChangeUser(DatabaseOfUsers users, out User actuallUser)
        {
            Console.WriteLine("Wybierz numer użytkownika którym chcesz operować");
            int i = int.Parse(Console.ReadLine());
            actuallUser = users.GetUser(i);
            return actuallUser;
        }
    }
}
