using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class BudgetEntry
    {
       private List<Budget> Budgets;
        public class Budget()
        {
            public string Type { get; set; }
            public double Amount { get; set; }
            public DateTime Date { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
        }
        public void NewBudget(string type, double amount, DateTime date, string category, string description)
        {
            Budget newBudget = new Budget
            {
                Type = type,
                Amount = amount,
                Date = date,
                Category = category,
                Description = description
            };
            Budgets.Add(newBudget);
        }
        public void RemoveBudget(Budget budget)
        {
            Budgets.Remove(budget);
        }
        public List<Budget> GetBudgets()
        {
            return Budgets;
        }
       

    }
}
