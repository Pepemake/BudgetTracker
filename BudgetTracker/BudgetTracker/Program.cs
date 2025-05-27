using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetTracker;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Tracker!");

            List<BudgetEntry.Budget> budgets = new List<BudgetEntry.Budget>();

            Console.WriteLine($"Please enter the type of budget (e.g., Income, Expense):");
            string usertype = Console.ReadLine();

            Console.WriteLine($"Please enter the amount for the budget:");
            double useramount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter the date for the budget (format: MM/dd/yyyy):");
            DateTime userdate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Please enter the category for the budget:");
            string usercategory = Console.ReadLine();

            Console.WriteLine($"Please enter a description for the budget:");
            string userdescription = Console.ReadLine();

            budgets.Add(new BudgetEntry.Budget
            {
                Type = usertype,
                Amount = useramount,
                Date = DateTime.TryParse(Console.ReadLine(), out userdate) ? userdate : DateTime.Now,
                Category = usercategory,
                Description = userdescription
            });

            Console.WriteLine($"{budgets.Count} budget(s) added successfully!");
        }
    }

}
