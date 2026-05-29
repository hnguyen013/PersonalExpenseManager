using System;
using PersonalExpenseManager.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseManager.DAL
{
    internal interface IUserDAL
    {
        List<User> ReadAll();
        bool CheckLogin(string username, string password);
    }
}
