using PersonalExpenseManager.Entity;
using System.Collections.Generic;

namespace PersonalExpenseManager.DAL
{
    internal interface IUserDAL
    {
        List<User> ReadAll();

        bool CheckLogin(string username, string password);

        bool Create(User user);

        bool IsUsernameExists(string username);
    }
}