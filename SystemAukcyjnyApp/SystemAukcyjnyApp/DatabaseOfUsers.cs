using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAukcyjnyApp
{
    public class DatabaseOfUsers
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User GetUser(int i)
        {
            return users.ElementAt(i);
        }

        public List<User> GetListOfUsers()
        {
            return users;
        }
}
}
