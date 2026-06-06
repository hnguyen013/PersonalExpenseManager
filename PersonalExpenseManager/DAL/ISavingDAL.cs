using PersonalExpenseManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseManager.DAL
{
    internal interface ISavingDAL
    {
        bool Create(Saving s);
        List<Saving> ReadAll();
        Saving ReadById(string id);
        bool Update(Saving s);
        bool DeleteById(string id);
        string GetNextId();
        string GetError();
    }
}
