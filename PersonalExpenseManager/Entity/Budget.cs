using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseManager.Entity
{
    internal class Budget
    {
        string id;
        string budgetName;
        string categoryId;
        double budgetAmount;
        double spent;
        string period;

        public Budget()
        {
        }

        public Budget(string id, string budgetName, string categoryId,
            double budgetAmount, double spent, string period)
        {
            this.id = id;
            this.budgetName = budgetName;
            this.categoryId = categoryId;
            this.budgetAmount = budgetAmount;
            this.spent = spent;
            this.period = period;
        }

        public string Id { get => id; set => id = value; }
        public string BudgetName { get => budgetName; set => budgetName = value; }
        public string CategoryID { get => categoryId; set => categoryId = value; }
        public double BudgetAmount { get => budgetAmount; set => budgetAmount = value; }
        public double Spent { get => spent; set => spent = value; }
        public string Period { get => period; set => period = value; }
    }
}
