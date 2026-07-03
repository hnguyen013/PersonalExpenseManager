using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseManager.Entity
{
    internal class Transaction
    {
        string id;
        string type;
        string categoryId;
        double amount;
        DateTime date;
        string notes;
        string budgetId;

        public Transaction()
        {

        }

        public Transaction(string id, string type,
            string categoryId, double amount,
            DateTime date, string notes)
        {
            this.id = id;
            this.type = type;
            this.categoryId = categoryId;
            this.amount = amount;
            this.date = date;
            this.notes = notes;
            this.budgetId = null;
        }
        public Transaction(string id, string type,
            string categoryId, double amount,
            DateTime date, string notes, string budgetId)
        {
            this.id = id;
            this.type = type;
            this.categoryId = categoryId;
            this.amount = amount;
            this.date = date;
            this.notes = notes;
            this.budgetId = budgetId;
        }
        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string CategoryID { get => categoryId; set => categoryId = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Notes { get => notes; set => notes = value; }
        public string BudgetId { get => budgetId; set => budgetId = value; }

    }
}
