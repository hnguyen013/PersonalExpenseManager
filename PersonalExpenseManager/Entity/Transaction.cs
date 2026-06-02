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
        string category;
        double amount;
        DateTime date;
        string notes;

        public Transaction()
        {

        }

        public Transaction(string id, string type,
            string category, double amount,
            DateTime date, string notes)
        {
            this.id = id;
            this.type = type;
            this.category = category;
            this.amount = amount;
            this.date = date;
            this.notes = notes;
        }

        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Category { get => category; set => category = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
