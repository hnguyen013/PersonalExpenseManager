using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExpenseManager.Entity;

namespace PersonalExpenseManager.DAL
{
    internal interface IBudgetDAL
    {
        bool Create(Budget b);

        List<Budget> ReadAll();

        Budget ReadById(string id);

        bool Update(Budget b);

        bool DeleteById(string id);

        bool ResetSpent(string id);

        string GetError();
    }
}
