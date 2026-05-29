using System;
using System.Collections.Generic;
using System.Linq;
using PersonalExpenseManager.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseManager.DAL
{
    internal class UserDAL : IUserDAL
    {
        private List<User> users;
        public UserDAL()
        {
            users = new List<User>();

            users.Add(new User("admin", "123456"));
            users.Add(new User("nguyen", "123456"));
        }
        public List<User> ReadAll()
        {
            return users;
        }
        public bool CheckLogin(string username, string password)
        {
            return users.Any(u => u.Username == username && u.Password == password);
        }
    }
}
