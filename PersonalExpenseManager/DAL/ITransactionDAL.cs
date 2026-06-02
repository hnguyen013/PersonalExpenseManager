using PersonalExpenseManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseManager.DAL
{
    internal interface ITransactionDAL
    {
        bool Create(Transaction t);

        List<Transaction> ReadAll();

        Transaction ReadById(string id);

        bool Update(Transaction t);

        bool DeleteById(string id);

        string GetError();
    }
}
