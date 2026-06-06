using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseManager.Entity
{
    internal class Saving
    {
        public string Id { get; set; }
        public string GoalName { get; set; }
        public double TargetAmount { get; set; }
        public double SavedAmount { get; set; }
        public DateTime TargetDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }

        public Saving() { }

        public Saving(string id, string goalName, double targetAmount,
            double savedAmount, DateTime targetDate, string notes, string status)
        {
            Id = id;
            GoalName = goalName;
            TargetAmount = targetAmount;
            SavedAmount = savedAmount;
            TargetDate = targetDate;
            Notes = notes;
            Status = status;
        }
    }
}
