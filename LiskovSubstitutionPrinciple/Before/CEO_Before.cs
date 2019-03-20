using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Before
{
    public class CEO_Before : Employee_Before
    {
        public override void AssignManager(Employee_Before manager)
        {
            throw new InvalidOperationException("The CEO has no manager.");
        }

        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direrct report's performance.");
        }

        public void FireSomone()
        {
            // Simulate firing someone
            Console.WriteLine("You're Fired!");
        }
    }
}
