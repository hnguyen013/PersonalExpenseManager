using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExpenseManager.Entity;

namespace PersonalExpenseManager.DAL
{
    internal interface ICategoryDAL
    {
        List<Category> ReadAll();
        bool Create(Category c);
        bool Update(Category c);
        bool Delete(string id);
        string GenerateID();
        string GetError();
    }
}